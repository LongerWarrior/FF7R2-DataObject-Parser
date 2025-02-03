﻿using CUE4Parse.UE4.Objects.UObject;

namespace FF7R2.DataObject;

public class MemoryImageVTablePatch(InnerAsset asset) {
    public FName vTableOffset;
    public uint  offset;

    internal void Read(BinaryReader reader) {
        vTableOffset = reader.ReadFName(asset.ioStoreAsset.names);
        offset       = reader.ReadUInt32();
    }

    internal void Write(BinaryWriter writer) {
        // TODO
        throw new NotImplementedException();
    }
}