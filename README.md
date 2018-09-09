# Drive
基於Docker技術的簡易檔案管理器

## 前言
隨VPS在現在資訊系統環境部屬上的普及應用，日常中有許多服務大部分轉移使用VPS
，在伺服器系統中常見的有Windows以及Linux，在使用Linux VPS時在部屬服務時
需要使用許多方式將程式執行檔搬移至VPS上執行，常見的方式有架設FTP等方法，或
者直接安裝XRDP，這在程式發布或上傳相關設定檔(如憑證)上較為不便。

## 規劃源起
本專案目標在於透過在VPS中使用Docker技術與其中的Volume串接技術，快速的部屬
基於Web的檔案管理器，提供服務相關設定檔案上傳與下載，由於Docker開箱即用的特
性，可以比過去使用wget、curl或FTP傳輸檔案的方式更加簡便。

## 規劃目標
本專案系統建置目標如下幾點：
1. 基於Docker佈署
2. 提供使用者管理，支援多使用者與兩種權限(一般、管理員)
3. 提供檔案目錄管理功能
4. 提供基於Web的使用者介面
5. 提供多檔上傳與檔案搬移

## 架構與開發環境
1. 系統架構
   1. 採用三層式(3-tier)架構
      1. 使用者介面層: 優先支援Chrome瀏覽器，採Angular進行開發前端介面。
      2. 運算邏輯層: 採用ASP.net Core技術運行，與使用者介面層的溝通採用RESTful API並搭配Swagger輔助開發，另外搭配EntityFrameworkCore技術與資料服務層溝通。
      3. 資料服務層: 採用Sqlite，本專案目標為目標單一的檔案瀏覽器，並無規劃其他功能，但由於資料邏輯層與本層的界皆使用EntityFrameworkCore，在未來更換資料庫時可以僅更換Database Provider。
   2. 佈署環境
      本專案基於Docker技術，在佈署服務時僅需取得相應的Docker映像啟動後即可運作。
      另外，作業系統支援部分，如非X64架構環境需另行建置映像檔。
2. 開發環境
   本專案採用前後端分離並且透過RESTful API進行溝通的架構，故以下分為前後端兩點說明。
   1. 前端
      1. Visual Studio Code
      1. Node.js
      2. Angular & Angular CLI
   2. 後端
      1. .Net Core SDK 2.1.400
      2. Visual Studio Community 2017