﻿using Arc.ES20;

namespace App.Objects
{
    internal interface IRenderObject: IDisposable
    {
        public int VAO { get; }

        public int VBO { get; }
        public void OnLoad(Shader shader);
        public void Reload(Shader shader);
        public void OnRenderFrame(Shader shader);
    }
}