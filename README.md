# Unity 项目模板

> **Unity 版本：** 6000.3.26f1 （Unity 6）\
> **渲染管线：** Universal Render Pipeline（URP）

本仓库是一个开箱即用的 Unity 项目预设包，集成了常用的第三方插件与框架，适合作为新项目的起始模板。

---

## 目录

- [插件清单](#插件清单)
  - [编辑器增强工具](#编辑器增强工具)
  - [游戏框架](#游戏框架)
  - [动画与 UI 特效](#动画与-ui-特效)
  - [架构与数据](#架构与数据)
- [项目结构](#项目结构)
- [快速开始](#快速开始)

---

## 插件清单

### 编辑器增强工具

| 插件 | 版本 | 说明 |
|------|------|------|
| **Odin Inspector**（Sirenix） | 4.0.1.2 | 强大的自定义 Inspector 与序列化系统，支持特性标注、验证器、列表/字典序列化等 |
| **vFolders** | 2.1.12 | Project 窗口文件夹着色与图标自定义，提升资源管理可读性 |
| **vHierarchy** | 2.1.7 | Hierarchy 窗口增强，支持分割线、折叠组、图标着色等 |
| **vInspector** | 2.0.17 | Inspector 窗口优化，提供更整洁的组件显示体验 |
| **vFavorites** | 2.0.13 | 快速收藏常用资源与对象，减少重复寻找成本 |
| **vTabs** | 2.1.4 | Inspector 多标签页支持，方便同时查看多个对象 |
| **MCP for Unity**（Coplay） | 10.3.0 | 通过 MCP 连接 AI 助手与 Unity 编辑器 |

MCP for Unity 使用 Git `main` 分支，表中为当前解析版本。

### 游戏框架

| 插件 | 版本 | 说明 |
|------|------|------|
| **QFramework** | v1.0.233 | 国产轻量级游戏开发框架，提供 MVC/IOC 架构支持 |
| **QFramework · AudioKit** | — | 音频管理模块，支持 BGM / SFX 播放、音量控制 |
| **QFramework · ResKit** | — | 资源加载模块，统一管理 AssetBundle 与 Resources 加载 |
| **QFramework · UIKit** | — | UI 管理模块，基于层级栈的界面打开/关闭系统 |
| **QFramework · CoreKit** | — | 框架核心，包含事件系统、命令系统、IOC 容器等基础能力 |

QFramework 工具包随框架集成，未单独标注版本。

### 动画与 UI 特效

| 插件 | 版本 | 说明 |
|------|------|------|
| **DOTween Pro**（Demigiant） | 1.0.386（DOTween 1.2.790） | 高性能补间动画库，支持路径动画、序列动画，Pro 版含可视化编辑器 |
| **Text Animator**（Febucci） | 2.3.1 | TextMeshPro 富文本动画系统，支持逐字出现、摇晃、渐变等效果 |

### 架构与数据

| 插件 | 版本 | 说明 |
|------|------|------|
| **SOAP**（Obvious） | 3.6.1 | 基于 ScriptableObject 的事件与数据总线架构，解耦模块间通信 |

---

## 项目结构

```
Assets/
├── _Game/                  # 游戏主体资源（项目核心工作目录）
│   ├── Animations/         # 动画片段与 Animator Controller
│   ├── Art/                # 美术资源（贴图、模型、材质等）
│   ├── Audio/              # 音频资源（BGM、SFX）
│   ├── Prefabs/            # 预制体
│   ├── Scenes/             # 场景文件
│   ├── Settings/           # 项目配置（渲染、输入等 Settings Asset）
│   ├── UI/                 # UI 资源（图集、字体、UI 预制体等）
│   └── Scripts/            # 游戏脚本
│       ├── Core/           # 核心逻辑（游戏管理、状态机等）
│       ├── Gameplay/       # 玩法脚本
│       ├── UI/             # UI 逻辑脚本
│       ├── Utils/          # 工具类与扩展方法
│       └── Editor/         # 编辑器扩展脚本
│
├── Plugins/                # 第三方插件
│   ├── Demigiant/          # DOTween & DOTween Pro
│   ├── Febucci/            # Text Animator
│   ├── Obvious/            # SOAP
│   ├── Sirenix/            # Odin Inspector
│   ├── vFolders/
│   ├── vHierarchy/
│   ├── vInspector/
│   ├── vFavorites/
│   └── vTabs/
│
├── QFramework/             # QFramework 框架本体
│   ├── Framework/          # 框架核心代码
│   └── Toolkits/           # 工具包
│       ├── _CoreKit/       # 核心工具包
│       ├── AudioKit/       # 音频管理
│       ├── ResKit/         # 资源管理
│       └── UIKit/          # UI 管理
│
├── Resources/              # 运行时动态加载资源
└── StreamingAssets/        # 流媒体资源（原始文件，随包发布）
```

---

## 快速开始

1. **克隆 / 下载**本仓库，使用 **Unity 6000.3.26f1** 打开项目。
2. 首次打开时 Unity 会自动导入资源，等待编译完成。
3. 开始实际开发时，可执行菜单 `Tools → Setup Project Folders`，补齐项目目录，并递归清理 `Assets/` 下所有 `.gitkeep` 及对应的 `.meta` 文件。
4. 打开 `Assets/_Game/Scenes/` 下的场景开始开发。
5. 新脚本建议放置于 `Assets/_Game/Scripts/` 对应分类目录下。
6. 如需使用 **DOTween**，首次使用前请执行菜单：`Tools → Demigiant → DOTween Utility Panel → Setup DOTween…`

模板中的空目录通过 `.gitkeep` 保留在 Git 中，确保克隆后目录与对应的 `.meta` 同时存在，避免首次导入时出现目录缺失警告。