using System;

namespace VoxelWorld
{
    [Serializable]
    public struct BlockSetup
    {
        public int toughness;
        public BlockType blockType;
        public BlockOpacity blockOpacity;
        public int health;
        public bool isFalling;
        public bool canBeDestroyed;
    }

    [Serializable]
    public struct LevelData
    {
        public float frequency;
        public float amplitude;
        public float offset;
    }
}