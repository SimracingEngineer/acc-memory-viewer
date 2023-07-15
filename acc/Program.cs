using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using acc;

MemoryMappedFile graphicsSharedMemory;
MemoryMappedFile physicsSharedMemory;
MemoryMappedFile staticSharedMemory;

try
{
    physicsSharedMemory = MemoryMappedFile.OpenExisting(@"Local\acpmf_physics");
    graphicsSharedMemory = MemoryMappedFile.OpenExisting(@"Local\acpmf_graphics");
    staticSharedMemory = MemoryMappedFile.OpenExisting(@"Local\acpmf_static");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Memory mapped files does not exist.");
    return;
}

using (var accessor = graphicsSharedMemory.CreateViewAccessor())
{
    bool keepReading = true;

    while (keepReading)
    {
        Console.Clear();

        using (var stream = graphicsSharedMemory.CreateViewStream())
        {
            using (var reader = new BinaryReader(stream))
            {
                var size = Marshal.SizeOf(typeof(GraphicsSharedMemoryStruct));
                var bytes = reader.ReadBytes(size);
                var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                var data = (GraphicsSharedMemoryStruct)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(GraphicsSharedMemoryStruct));
                handle.Free();
                Console.WriteLine(data.currentTime);
            }
        }
        Thread.Sleep(100);
    }
}