using System.Collections.Generic;

namespace Skyrim
{
    internal class Scene
    {
        public List<SubScene> SubScenes { get; set; }

        public static Scene HelgenKeep { get; } = new Scene();
        public static Scene Riverwood { get; } = new Scene();
        public static Scene Whiterun { get; } = new Scene();

        static Scene()
        {
            HelgenKeep.SubScenes = new List<SubScene>()
            {
                SubScene.HelgenKeepBarracks,

            };

            Riverwood.SubScenes = new List<SubScene>()
            {
            };

            Whiterun.SubScenes = new List<SubScene>()
            {
            };
        }
    }
}
