using System;

namespace VoxelWorld
{
    [Serializable]
    public static class Settings
    {
        public const int RENDER_DISTANCE = 5;
        public const int CHUNK_SIZE = 16;
        public const int AUTOSAVE_DELAY = 10;
        public const int HOTBAR_LENGTH = 9;
        public const int MAX_COROUTINES = 1024;
        public const int OCEAN_HEIGHT = 40;
        public const bool SAVE_ALL_CHUNKS = false;
    }
}
