﻿using System.Runtime.InteropServices;

namespace DRM
{
    public enum EncoderType : uint
    {
        NONE = 0,
        DAC = 1,
        TMDS = 2,
        LVDS = 3,
        TVDAC = 4,
        VIRTUAL = 5,
        DSI = 6,
        DPMST = 7,
        DPI = 8,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct drmEncoder
    {
        public uint encoder_id;
        public EncoderType encoder_type;
        public uint crtc_id;
        public uint possible_crtcs;
        public uint possible_clones;
    }

    unsafe public class Encoder : IDisposable
    {
        #region pinvoke
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        internal static extern drmEncoder* drmModeGetEncoder(int fd, uint encoder_id);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void drmModeFreeEncoder(drmEncoder* ptr);
        #endregion

        int fd_gpu;
        internal drmEncoder* handle;

        #region ctor
        unsafe internal Encoder(int _fd_gpu, uint _id)
        {
            fd_gpu = _fd_gpu;
            handle = drmModeGetEncoder(fd_gpu, _id);

            if (handle == null)
                throw new NotSupportedException("[DRI] drmModeGetEncoder failed.");
        }
        #endregion

        public uint Id { get { return handle->encoder_id; } }
        public EncoderType Type { get { return handle->encoder_type; } }
        public uint PossibleCrtcs { get { return handle->possible_crtcs; } }
        public uint PossibleClones { get { return handle->possible_clones; } }

        public Crtc? CurrentCrtc
        {
            get => handle->crtc_id == 0 ? null : new Crtc(fd_gpu, handle->crtc_id);
        }

        #region IDisposable implementation
        ~Encoder()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            unsafe
            {
                if (handle != null)
                    drmModeFreeEncoder(handle);
                handle = null;
            }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("[Encoder: Id={0}, Type={1}, PossibleCrtcs={2}, PossibleClones={3}]", Id, Type, PossibleCrtcs, PossibleClones);
        }
    }
}

