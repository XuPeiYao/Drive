import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { driveApi } from '../../../../../../environments/driveApi';
import { environment } from '../../../../../../environments/environment.prod';
import { HttpClientBase } from '../../../../../services/http-client-base.service';

@Injectable({
  providedIn: 'root'
})
export class FileService {
  constructor(public http: HttpClientBase) {}

  public list(path: string | string[], skip: number = 0, take: number = 10) {
    return this.http.get(driveApi.file.list, {
      path,
      skip,
      take
    });
  }
}