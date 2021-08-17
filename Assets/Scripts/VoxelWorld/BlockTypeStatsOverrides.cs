using System.Collections.Generic;

namespace VoxelWorld
{
    public static class BlockTypeStatsOverrides
    {
        public static readonly Dictionary<BlockType, BlockSetup> blockSetups = new Dictionary<BlockType, BlockSetup>()
        {
            {
                BlockType.Air,
                new BlockSetup()
                {
                    blockType = BlockType.Air,
                    health = int.MaxValue,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Transparent,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Bedrock,
                new BlockSetup()
                {
                    blockType = BlockType.Bedrock,
                    health = 1,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = false
                }
            },
            {
                BlockType.Dirt,
                new BlockSetup()
                {
                    blockType = BlockType.Dirt,
                    health = 4,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Stone,
                new BlockSetup()
                {
                    blockType = BlockType.Stone,
                    health = 6,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Brick,
                new BlockSetup()
                {
                    blockType = BlockType.Brick,
                    health = 16,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Planks,
                new BlockSetup()
                {
                    blockType = BlockType.Planks,
                    health = 3,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Leaves,
                new BlockSetup()
                {
                    blockType = BlockType.Leaves,
                    health = 2,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Water,
                new BlockSetup()
                {
                    blockType = BlockType.Water,
                    health = 8,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Liquid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Sand,
                new BlockSetup()
                {
                    blockType = BlockType.Sand,
                    health = 4,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = true,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Gravel,
                new BlockSetup()
                {
                    blockType = BlockType.Gravel,
                    health = 4,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = true,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.Cobblestone,
                new BlockSetup()
                {
                    blockType = BlockType.Cobblestone,
                    health = 6,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.CoalOre,
                new BlockSetup()
                {
                    blockType = BlockType.CoalOre,
                    health = 8,
                    toughness = 1,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.IronOre,
                new BlockSetup()
                {
                    blockType = BlockType.IronOre,
                    health = 8,
                    toughness = 2,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.GoldOre,
                new BlockSetup()
                {
                    blockType = BlockType.GoldOre,
                    health = 8,
                    toughness = 3,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
            {
                BlockType.RedstoneOre,
                new BlockSetup()
                {
                    blockType = BlockType.RedstoneOre,
                    health = 8,
                    toughness = 3,
                    blockOpacity = BlockOpacity.Solid,
                    isFalling = false,
                    canBeDestroyed = true
                }
            },
        };
    }
}