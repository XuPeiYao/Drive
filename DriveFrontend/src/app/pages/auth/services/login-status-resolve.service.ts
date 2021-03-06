import { Injectable } from '@angular/core';
import { Resolve, Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { driveApi } from 'src/environments/driveApi';

/**
 * 登入狀態檢驗
 */
@Injectable({
  providedIn: 'root'
})
export class LoginStatusResolveService implements Resolve<string> {
  constructor(private router: Router, private http: HttpClient) {}

  async resolve(): Promise<string> {
    // 取得儲存的Token
    const token =
      localStorage.getItem('token') || sessionStorage.getItem('token');

    if (token) {
      try {
        // 嘗試驗證與取得使用者Role
        const role = await this.http
          .post<string>(driveApi.user.verify, JSON.stringify(token), {
            headers: new HttpHeaders().set('Content-Type', 'application/json')
          })
          .toPromise();

        if (!role) {
          return '登入過期';
        }

        sessionStorage.setItem('role', role);
        localStorage.setItem('role', role);

        // 有效Token導引至檔案頁
        this.router.navigateByUrl('/manage/file');
      } catch {
        return '登入驗證失敗，請檢查網路';
      }
    }
  }
}
