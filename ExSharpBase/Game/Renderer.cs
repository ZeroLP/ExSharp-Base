using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using ExSharpBase.Modules;

namespace ExSharpBase.Game
{
    class Renderer
    {
        private static int ViewMatrix = OffsetManager.Instances.ViewMatrix;
        private static int ProjectionMatrix = ViewMatrix + 0x40;

        private const int Width = 0x0014;
        private const int Height = Width + 0x4;

        public static int Instance { get; } = Memory.Read<int>(OffsetManager.Instances.Renderer);

        public static Matrix GetViewProjectionMatrix()
        {
            return Matrix.Multiply(GetViewMatrix(), GetProjectionMatrix());
        }

        public static Matrix GetViewMatrix()
        {
            return Memory.ReadMatrix(ViewMatrix);
        }

        public static Matrix GetProjectionMatrix()
        {
            return Memory.ReadMatrix(ProjectionMatrix);
        }

        public static Vector2 GetScreenResolution()
        {
            return new Vector2() { X = Memory.Read<int>(Instance + Width), Y = Memory.Read<int>(Instance + Height) };
        }

        public static Vector2 WorldToScreen(Vector3 pos)
        {
            Vector2 returnVec = Vector2.Zero;

            Vector2 screen = GetScreenResolution();
            Matrix matrix = GetViewProjectionMatrix();

            Vector4 clipCoords;
            clipCoords.X = pos.X * matrix[0] + pos.Y * matrix[4] + pos.Z * matrix[8] + matrix[12];
            clipCoords.Y = pos.X * matrix[1] + pos.Y * matrix[5] + pos.Z * matrix[9] + matrix[13];
            clipCoords.Z = pos.X * matrix[2] + pos.Y * matrix[6] + pos.Z * matrix[10] + matrix[14];
            clipCoords.W = pos.X * matrix[3] + pos.Y * matrix[7] + pos.Z * matrix[11] + matrix[15];

            if (clipCoords[3] < 0.1f) return returnVec;

            Vector3 M;
            M.X = clipCoords.X / clipCoords.W;
            M.Y = clipCoords.Y / clipCoords.W;
            M.Z = clipCoords.Z / clipCoords.W;

            returnVec.X = (screen.X / 2 * M.X) + (M.X + screen.X / 2);
            returnVec.Y = -(screen.Y / 2 * M.Y) + (M.Y + screen.Y / 2);

            return returnVec;
        }
    }
}
