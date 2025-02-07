# JsReport Studio .NET

A .NET-based reporting application that integrates jsreport for generating, designing, and managing reports through a web-based interface.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Node.js](https://nodejs.org/) (automatically managed by jsreport.Binary)
- Modern web browser (Chrome recommended)

## Installation & Running

1. **Clone and Navigate**
```bash
git clone https://github.com/AltafEmpaxis/jsreport-studio-playground.git
cd jsreport-studio-playground
```

2. **First Time Setup**
```bash
# Clean any existing builds
dotnet clean

# Remove existing binaries and cache (if any)
rd /s /q bin obj jsreport

# Restore packages
dotnet restore
```

3. **Build and Run**
```bash
dotnet build
dotnet run
```

4. **Access the Application**
- Open your browser
- Go to http://localhost:5488
- The jsreport studio will start automatically

## Contributing

If you want to contribute to this project:

1. **Fork and Clone**
```bash
# Fork the repository on GitHub first, then clone your fork
git clone https://github.com/YOUR-USERNAME/jsreport-studio-playground.git
cd jsreport-studio-playground
```

2. **Set Up Remote**
```bash
# Add the upstream repository
git remote add origin https://github.com/AltafEmpaxis/jsreport-studio-playground.git
git branch -M main
```

3. **Push Changes**
```bash
# After making your changes
git add .
git commit -m "Your commit message"
git push -u origin main
```

## Configuration Details

The application is configured in `jsreport.config.json` with these settings:

```json
{
  "httpPort": 5488,
  "allowLocalFilesAccess": true,
  "store": {
    "provider": "fs"
  },
  "extensions": {
    "authentication": {
      "enabled": false,
      "admin": {
        "username": "admin",
        "password": "password"
      }
    },
    "sample-template": {
      "createSamples": true
    },
    "chrome-pdf": {
      "timeout": 30000,
      "strategy": "chrome-pool"
    },
    "scripts": {
      "timeout": 30000,
      "allowedModules": ["fs", "path", "lodash"]
    },
    "assets": {
      "searchOnDisk": true,
      "allowedFiles": "**/*.*"
    },
    "express": {
      "inputRequestLimit": "50mb"
    },
    "browser-client": {
      "timeout": 10000
    }
  }
}
```

## Quick Reference

- **Default URL**: http://localhost:5488
- **Authentication**: Disabled by default
- **Sample Templates**: Automatically created on first run
- **Supported Formats**: PDF, Excel, Word, HTML
- **Storage**: File-based (stored in jsreport/data)

## Troubleshooting

If the application doesn't start:

1. **Check Port**
```bash
# See if port 5488 is in use
netstat -ano | findstr :5488
```

2. **Kill Existing Process**
```bash
# If port is in use, kill the process
taskkill /F /IM jsreport.exe
taskkill /F /IM node.exe
```

3. **Fresh Start**
```bash
# Clean everything and start fresh
dotnet clean
rd /s /q bin obj jsreport
dotnet restore
dotnet run
```

## Support

- [jsreport Documentation](https://jsreport.net/learn)
- [jsreport Forum](https://forum.jsreport.net/)