/*Copyright 2015 Huawei Technologies Co., Ltd. All rights reserved.
eSDK is licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
		http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.*/

/******************************************************************************
   ��Ȩ���� (C), 2001-2011, ��Ϊ�������޹�˾

 ******************************************************************************
  �� �� �� : RtspReactorManager.h
  ��    �� : y00182336
  �������� : RTSP Client��Ӧ������
  �޸���ʷ :
    1 ���� : 2011-10-12
      ���� : y00182336
      �޸� : ����

 ******************************************************************************/


#ifndef __RTSPREACTORMANAGER_H_
#define __RTSPREACTORMANAGER_H_

#include "ace_header.h"
#include "RtspSession.h"

#include <list>
using namespace std;


/// �����߳�����
#define RTSP_THREAD_NUM                     (5)

/// ����EPOLL�пɹ�����FD��С
#ifndef WIN32
#define RTSP_MAX_EPOLL_SIZE                 (10000)
#else
#define RTSP_MAX_EPOLL_SIZE                 (1024)
#endif

/// ����ÿ���߳������ʱ�䣬500ms
#define RTSP_MAX_TIME_PER_THREAD            (500 * 1000)

/// �����̶߳�ջ��С
#define DEFAULT_THREAD_STACK_SIZE           (128 * 1024)


class CRtspReactorManager : public ACE_Task<ACE_MT_SYNCH>
{
public:
    virtual ~CRtspReactorManager();

    static CRtspReactorManager* instance()
    {
        static CRtspReactorManager ReactorManager;
        return &ReactorManager;
    }

    // �򿪹�����
    int openManager();

    // �رչ�����
    int closeManager();

    // �̻߳ص�
    int svc();
    
    //ע������¼�
    int RegistHandle(CRtspSession *pHandle, unsigned long mask);
    
    //ȡ�������¼�
    int unRegistHandle(const ACE_Event_Handler *pHandle, unsigned long mask) const;

    //ע�ᶨʱ��
    long RegistTimer(ACE_Event_Handler *pHandle, unsigned int unIndex,
                     const ACE_Time_Value &delta,
                     const ACE_Time_Value &interval) const;

    //ȡ����ʱ��
    int unRegistTimer(long timer_id, unsigned int unIndex) const;

private:
    CRtspReactorManager();
    
    unsigned int getThreadIndex();

    // ������Դ
    int createResources();

    // �����߳�
    int createServiceThreads();

private:
    bool                        m_bRunFlag;                     /// �߳����б�־

    unsigned int                m_ThreadNum;                    /// �̺߳�
    ACE_Thread_Mutex            m_ThreadNumMutex;               /// �̺߳���

    ACE_Reactor**               m_pReactor;                     /// ��Ӧ��

};

#endif /*__RTSPREACTORMANAGER_H_*/
