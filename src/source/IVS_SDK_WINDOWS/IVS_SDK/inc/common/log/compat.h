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

/*******************************************************************************
//  版权所有    2012 华为技术有限公司
//  程 序 集：  IVS_Player
//  文 件 名：  compat.h
//  文件说明:   
//  版    本:   IVS V100R002C01
//  作    者:   w00210470
//  创建日期:   2012/11/12
//  修改标识：
//  修改说明：
*******************************************************************************/
#ifndef  __IVS_COMPAT_UTIL_H__
#define  __IVS_COMPAT_UTIL_H__

#include <time.h>     // time_t
#include <stdarg.h>   // va_list definition

#ifdef _MSC_VER
#include <WinSock.h>  // struct timeval definition
#endif 

#if defined __GNUC__ || defined LINUX
# include <sys/time.h>  // for gettimeofday
#endif

/* strings */
int IVS_vsnprintf(char *buffer, size_t count, const char *format, va_list argptr);
int IVS_snprintf(char *buffer, size_t count, const char *format, ...);
int IVS_strcasecmp(const char *string1, const char *string2);
int IVS_strncasecmp(const char *s1, const char* s2, size_t count);

/* time */
int IVS_localtime(struct tm *_tm, const time_t *_tt);
int IVS_gettimeofday(struct timeval *tv);

#endif //  __IVS_COMPAT_UTIL_H__
