import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AbpHttpInterceptor } from '@yoyo/abp';

import * as ApiServiceProxies from '@shared/service-proxies/service-proxies';

@NgModule({
  providers: [
    ApiServiceProxies.RoleServiceProxy,
    ApiServiceProxies.SessionServiceProxy,
    ApiServiceProxies.TenantServiceProxy,
    ApiServiceProxies.UserServiceProxy,
    ApiServiceProxies.TokenAuthServiceProxy,
    ApiServiceProxies.AccountServiceProxy,
    ApiServiceProxies.ConfigurationServiceProxy,
    // 公开创建租户的Api
    ApiServiceProxies.TenantRegistrationServiceProxy,

    // 云书单
    ApiServiceProxies.BookTagServiceProxy,
    ApiServiceProxies.BookServiceProxy,
    ApiServiceProxies.BookListServiceProxy,

    { provide: HTTP_INTERCEPTORS, useClass: AbpHttpInterceptor, multi: true },
  ],
})
export class ServiceProxyModule { }
