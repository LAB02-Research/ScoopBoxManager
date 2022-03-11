[![GitHub release (latest by date)](https://img.shields.io/github/v/release/LAB02-Research/ScoopBoxManager)](https://github.com/LAB02-Research/ScoopBoxManager/releases/)
[![License](https://img.shields.io/badge/License-MIT-blue)](#license)
[![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://www.microsoft.com/ "Go to Microsoft homepage")
![GitHub all releases](https://img.shields.io/github/downloads/LAB02-Research/ScoopBoxManager/total?color=blue)
[![buymeacoffee](https://img.shields.io/badge/BuyMeACoffee-Donate-blue.svg)](https://www.buymeacoffee.com/lab02research)

<a href="https://github.com/LAB02-Research/ScoopBoxManager/">
    <img src="https://raw.githubusercontent.com/LAB02-Research/ScoopBoxManager/main/images/logo_128.png" alt="ScoopBoxManager logo" title="ScoopBoxManager" align="right" height="128" />
</a>

# ScoopBox Manager

ScoopBox Manager is a Windows-based application to prepare and launch [Windows Sandbox](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-sandbox/windows-sandbox-overview) instances, developed in .NET 6.

Click [here](https://github.com/LAB02-Research/ScoopBoxManager/releases/latest/download/ScoopBoxManager.zip) to download the latest release.

----

Before starting, make sure you have [Windows Sandbox](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-sandbox/windows-sandbox-overview) enabled. For more info [consult the docs](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-sandbox/windows-sandbox-overview#installation), or you can use this PS script:

```powershell
Enable-WindowsOptionalFeature -FeatureName "Containers-DisposableClientVM" -All -Online
```

----

[Windows Sandbox](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-sandbox/windows-sandbox-overview) is a way to launch applications, visit websites, test code, etc. within a secure and clean environment. This environment is a basic copy of your OS, running as a virtual machine. As soon as you close the sandbox, everything you've done and changed will be gone. Open a new one, and you'll get a fresh new copy.

That's also a bit of a setback: if you need some applications or frameworks installed for your tests, you'd have to reinstall them every time you launch a new sandbox. Or what if you want to access a local folder, for instance your application's debug output path?

[@hasan-hasanov](https://github.com/hasan-hasanov) created a perfect library to deal with that; [ScoopBox](https://github.com/hasan-hasanov/ScoopBox). It allows a developer to configure certain settings, and have the sandbox install predefined applications through the package managers [Scoop](https://scoop.sh) and [Chocolatey](https://chocolatey.org/).

For those that aren't C# programmers, or if you want an easy way to configure your sandboxes (like me), I built a small graphical interface around [ScoopBox](https://github.com/hasan-hasanov/ScoopBox):

![Interface](https://raw.githubusercontent.com/LAB02-Research/ScoopBoxManager/main/images/main_interface.png)

It should be pretty self-explanatory, and you can find more info on the various settings in the [ScoopBox readme](https://github.com/hasan-hasanov/ScoopBox#how-scoopbox-works), but I'll expand on some parts:

### General configuration

The defaults are fine, but you can for instance disable networking to see how your applications handles it. When setting memory, 0 means the default.

### Optional configuration

These are configured by [ScoopBox](https://github.com/hasan-hasanov/ScoopBox), so there's usually no reason to change these.

### Mapped folders

These are local folders that will show up in your sandbox, optionally readonly for added safety if you're testing potential malware.

### Applications

A list of packages that will be installed. You can define which package manager per package; [Scoop](https://scoop.sh) or [Chocolatey](https://chocolatey.org/). Please note that you need networking enabled for this, and depending on which and the amount of packages, it might take a few moments before everything's installed.

### Storage

You can use the two buttons on the bottom-right to store and load multiple configurations. Whenever you launch a sandbox, the active settings are stored as the default (and loaded when you restart). So if it's just one set of config you use, you don't have to use them.

### Logging

[ScoopBox](https://github.com/hasan-hasanov/ScoopBox) writes logfiles to the desktop of your sandbox. They contain info on what the package managers did, so if something's not installing, check those first.

---

If you need a cli tool to launch sandboxes, [@hasan-hasanov](https://github.com/hasan-hasanov) built that as well: [Boxer](https://github.com/hasan-hasanov/Boxer)
