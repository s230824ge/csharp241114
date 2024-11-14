# CSharp241114 Project

這個專案主要作為教學之用，內容將包含以下幾個部分：

## 天氣 API
提供天氣資訊的 API，包含查詢當前天氣、未來天氣預報等功能。

## 產品資訊 API
提供產品資訊的 API，具備 CRUD 操作功能，包含新增、查詢、更新及刪除產品資訊。

## 待辦事項專案
主要的待辦事項專案內容，提供管理待辦事項的功能。

## 執行環境
此專案可執行於 HTTP / HTTPS 的 Web 服務環境上。

## 如何開始
1. 克隆此專案到本地端：
    ```bash
    git clone https://github.com/yourusername/csharp241114.git
    ```
2. 進入專案目錄：
    ```bash
    cd csharp241114
    ```
3. 安裝所需的依賴：
    ```bash
    dotnet restore
    ```
4. 執行專案：
    ```bash
    dotnet run
    # 執行 https，需要先確定有建立和信任自簽 cert 
    dotnet dev-certs https --trust
    dotnet run --launch-profile https
    ```

## 如何使用 ASP.NET Core Scaffolding 工具

### 透過 `dotnet aspnet-codegenerator` 進行

如果 `dotnet aspnet-codegenerator` 顯示無法執行或找不到指令的錯誤訊息，通常是因為 **ASP.NET Core Scaffolding 工具** 尚未安裝。

#### **安裝 ASP.NET Core Scaffolding 工具**

在 `Terminal` 中，跳轉到專案目錄下執行指令，將 Scaffolding 工具安裝到專案中：

```bash
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
# 有時候可能還需要安裝 dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
# 或是更新 dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
```

### **安裝完成後重新還原套件**

安裝完後，還需要執行 `dotnet restore` 來確保所有相依套件已成功載入：

```bash
dotnet restore
```

### **再次執行 Scaffolding 指令**

安裝完成後，嘗試執行 Scaffolding 指令。例如：

```bash
dotnet aspnet-codegenerator controller -name ProductsController -actions -outDir Controllers
```

### **檢查 .NET SDK 和 CLI 版本**

確保你的 .NET SDK 版本支援 `aspnet-codegenerator` 指令。執行以下命令確認 SDK 版本：

```bash
dotnet --version
```

建議使用 **.NET Core 3.1 或以上版本** 的 SDK，ASP.NET Core Scaffolding 工具在較新版本中才完整支援。

### **檢查 ASP.NET Core Web 應用專案類型**

確保你的專案是 **ASP.NET Core Web 專案 **，因為 `aspnet-codegenerator` 主要針對 Web 專案。如果你的專案不是 Web 類型，可能會出現錯誤。

## 更新所有過期的套件 (可不執行)

```bash
dotnet outdated --upgrade
```

如果 `dotnet outdated --upgrade` 顯示無法執行或找不到指令的錯誤訊息，可能是套件未安裝。

#### **安裝 dotnet-outdated 工具**

在 `Terminal` 中，跳轉到專案目錄下執行指令，將 dotnet-outdated 工具安裝到專案中：

```bash
dotnet tool install --global dotnet-outdated-tool
```

## 貢獻
歡迎提交問題與請求，或是貢獻程式碼。

## 授權
此專案採用 MIT 授權條款。詳情請參閱 [LICENSE](LICENSE) 文件。