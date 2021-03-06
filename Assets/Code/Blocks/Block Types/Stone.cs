﻿using UnityEngine;
using System.Collections;

public class Stone : BlockSolid
{

    public Stone() : base() { }

    public override void BuildFace(Chunk chunk, BlockPos pos, MeshData meshData, Direction direction)
    {
        BlockBuilder.BuildRenderer(chunk, pos, meshData, direction, this);
        BlockBuilder.BuildTexture(chunk, pos, meshData, direction, this, Textures.Stone);
        BlockBuilder.BuildColors(chunk, pos, meshData, direction, this);
        BlockBuilder.BuildCollider(chunk, pos, meshData, direction, this);
    }
}
