using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SharpDX;


namespace ExSharpBase.Modules
{
    class Memory
    {
        public static T Read<T>(int Address)
        {
            var Size = Marshal.SizeOf<T>();
            var Buffer = new byte[Size];
            bool Result = NativeImport.ReadProcessMemory(Process.GetProcessesByName("League of Legends").FirstOrDefault().Handle, (IntPtr)Address, Buffer, Size, out var lpRead);
            var Ptr = Marshal.AllocHGlobal(Size);
            Marshal.Copy(Buffer, 0, Ptr, Size);
            var Struct = Marshal.PtrToStructure<T>(Ptr);
            Marshal.FreeHGlobal(Ptr);
            return Struct;
        }

        public static string ReadString(int address, Encoding Encoding)
        {
            byte[] dataBuffer = new byte[512];
            IntPtr bytesRead = IntPtr.Zero;

            NativeImport.ReadProcessMemory(System.Diagnostics.Process.GetProcessesByName("League of Legends").FirstOrDefault().Handle, (IntPtr)address, dataBuffer, dataBuffer.Length, out bytesRead);

            if (bytesRead == IntPtr.Zero)
            {
                return string.Empty;
            }

            return Encoding.GetString(dataBuffer).Split('\0')[0];
        }

        public static Matrix ReadMatrix(int address)
        {
            Matrix tmp = Matrix.Zero;

            byte[] Buffer = new byte[64];
            IntPtr ByteRead;

            NativeImport.ReadProcessMemory(Process.GetProcessesByName("League of Legends").FirstOrDefault().Handle, (IntPtr)address, Buffer, 64, out ByteRead);

            if (ByteRead == IntPtr.Zero)
            {
                //Console.WriteLine($"[ReadMatrix] No bytes has been read at 0x{address.ToString("X")}");
                return new Matrix();
            }

            tmp.M11 = BitConverter.ToSingle(Buffer, (0 * 4));
            tmp.M12 = BitConverter.ToSingle(Buffer, (1 * 4));
            tmp.M13 = BitConverter.ToSingle(Buffer, (2 * 4));
            tmp.M14 = BitConverter.ToSingle(Buffer, (3 * 4));

            tmp.M21 = BitConverter.ToSingle(Buffer, (4 * 4));
            tmp.M22 = BitConverter.ToSingle(Buffer, (5 * 4));
            tmp.M23 = BitConverter.ToSingle(Buffer, (6 * 4));
            tmp.M24 = BitConverter.ToSingle(Buffer, (7 * 4));

            tmp.M31 = BitConverter.ToSingle(Buffer, (8 * 4));
            tmp.M32 = BitConverter.ToSingle(Buffer, (9 * 4));
            tmp.M33 = BitConverter.ToSingle(Buffer, (10 * 4));
            tmp.M34 = BitConverter.ToSingle(Buffer, (11 * 4));

            tmp.M41 = BitConverter.ToSingle(Buffer, (12 * 4));
            tmp.M42 = BitConverter.ToSingle(Buffer, (13 * 4));
            tmp.M43 = BitConverter.ToSingle(Buffer, (14 * 4));
            tmp.M44 = BitConverter.ToSingle(Buffer, (15 * 4));

            return tmp;
        }

        public static Vector3 Read3DVector(int address)
        {
            Vector3 tmp = new Vector3();

            byte[] Buffer = new byte[12];
            IntPtr ByteRead;

            NativeImport.ReadProcessMemory(Process.GetProcessesByName("League of Legends").FirstOrDefault().Handle, (IntPtr)(address + Game.OffsetManager.Object.Pos), Buffer, 12, out ByteRead);

            tmp.X = BitConverter.ToSingle(Buffer, (0 * 4));
            tmp.Y = BitConverter.ToSingle(Buffer, (1 * 4));
            tmp.Z = BitConverter.ToSingle(Buffer, (2 * 4));

            return tmp;
        }
    }
}
