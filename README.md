# JsReport Studio .NET

A .NET-based reporting application that integrates jsreport for generating, designing, and managing reports through a web-based interface.

## Running the Application

Follow these steps to get the application up and running:

1. **Prerequisites**
   - Install [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
   - Install [Node.js](https://nodejs.org/) (automatically managed by jsreport.Binary)
   - Use a modern web browser (Chrome recommended)
   - Visual Studio 2022 or VS Code (optional)

2. **Clone the Repository**
```bash
git clone https://github.com/AltafEmpaxis/jsreport-studio-playground.git
cd jsreport-studio-playground
```

3. **First Time Setup**
```bash
# Clean any existing builds
dotnet clean

# Remove existing binaries and cache (if any)
rd /s /q bin obj jsreport

# Restore packages
dotnet restore
```

4. **Build and Run**
```bash
dotnet build
dotnet run
```

5. **Access the Application**
   - Open your web browser
   - Navigate to http://localhost:5488
   - The jsreport studio will start automatically

The application runs on **port 5488** by default. You can change this in the `jsreport.config.json` file if needed.

## Package Dependencies

```xml
<PackageReference Include="jsreport.Binary" Version="3.8.0" />
<PackageReference Include="jsreport.Local" Version="3.8.2" />
<PackageReference Include="Microsoft.Extensions.Logging.Console" Version="9.0.1" />
```

## Project Structure

```
jsreport-studio-playground/
├── Program.cs              # Main application entry point
├── JsReportStudio.csproj  # Project file with dependencies
├── jsreport.config.json   # jsreport configuration
└── jsreport/             # Report templates and assets directory (auto-generated)
    └── data/             # Stored templates and data
```

## Configuration

The application uses `jsreport.config.json` for configuration:

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
    }
  }
}
```

### Changing the Port

To use a different port:

1. Update the `httpPort` in `jsreport.config.json`:
```json
{
  "httpPort": YOUR_PORT_NUMBER,
  ...
}
```

2. Or set it through environment variable:
```bash
set JSREPORT_PORT=YOUR_PORT_NUMBER
dotnet run
```

## Features

- Web-based template designer
- Multiple output formats (PDF, Excel, Word, HTML)
- Asset management
- Sample templates included
- File-based storage
- No authentication required (by default)

## Development

### Requirements
- Visual Studio 2022 or VS Code
- .NET 9.0 SDK
- Git
- Node.js

### Debug Mode
1. Open the solution in Visual Studio
2. Set breakpoints in `Program.cs`
3. Press F5 to start debugging

### VS Code Setup
1. Install C# extension
2. Open the folder
3. Use the `.vscode/launch.json` for debugging configuration

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

4. **Common Issues**
   - Port 5488 already in use
   - Node.js not installed or wrong version
   - Missing .NET SDK
   - Insufficient permissions for file system access

## Repository Information

- **Repository**: [jsreport-studio-playground](https://github.com/AltafEmpaxis/jsreport-studio-playground)
- **Clone URL**: `https://github.com/AltafEmpaxis/jsreport-studio-playground.git`
- **Branch**: `main`

## Support

- [jsreport Documentation](https://jsreport.net/learn)
- [jsreport Forum](https://forum.jsreport.net/)