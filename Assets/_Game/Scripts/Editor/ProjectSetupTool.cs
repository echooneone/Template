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
        }

        foreach (string pattern in new[] { ".gitkeep", ".gitkeep.meta" })
        {
            foreach (string filePath in Directory.EnumerateFiles(Application.dataPath, pattern, SearchOption.AllDirectories))
            {
                File.Delete(filePath);
            }
        }

        AssetDatabase.Refresh();
        Debug.Log("项目目录结构已生成，Assets 下所有 .gitkeep 及对应 .meta 已清理！保持清晰，保持高效。");
    }
}
