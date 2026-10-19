using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class ProjectSetupTool
{
    [MenuItem("Tools/Setup Project Folders")]
    public static void CreateBasicStructure()
    {
        string root = "_Game"; // 你的核心项目根目录名

        List<string> folders = new List<string>()
        {
            // 根目录结构
            "ThirdParty",
            "Plugins",
            "StreamingAssets",
            
            // _Game 内部结构
            $"{root}/Animations/Clips",
            $"{root}/Animations/Controllers",
            
            $"{root}/Art/Materials",
            $"{root}/Art/Models/Characters",
            $"{root}/Art/Models/Environment",
            $"{root}/Art/Shaders",
            $"{root}/Art/Textures",
            
            $"{root}/Audio/BGM",
            $"{root}/Audio/SFX",
            
            $"{root}/Prefabs/Characters",
            $"{root}/Prefabs/Environment",
            $"{root}/Prefabs/UI",
            $"{root}/Prefabs/VFX",
            
            $"{root}/Scenes/Levels",
            $"{root}/Scenes/Sandboxes",
            
            $"{root}/Scripts/Core",
            $"{root}/Scripts/Gameplay",
            $"{root}/Scripts/UI",
            $"{root}/Scripts/Utils",
            $"{root}/Scripts/Editor",
            
            $"{root}/Settings",
            
            $"{root}/UI/Fonts",
            $"{root}/UI/Icons",
            $"{root}/UI/Sprites",
        };

        foreach (string folder in folders)
        {
            string path = Path.Combine(Application.dataPath, folder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            RemoveGitKeep(Path.Combine(path, ".gitkeep"));
        }

        string gameRoot = Path.Combine(Application.dataPath, root);
        foreach (string gitKeepPath in Directory.EnumerateFiles(gameRoot, ".gitkeep", SearchOption.AllDirectories))
        {
            RemoveGitKeep(gitKeepPath);
        }

        AssetDatabase.Refresh();
        Debug.Log("项目目录结构已生成，.gitkeep 占位文件已清理！保持清晰，保持高效。");
    }

    private static void RemoveGitKeep(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        string metaPath = path + ".meta";
        if (File.Exists(metaPath))
        {
            File.Delete(metaPath);
        }
    }
}
