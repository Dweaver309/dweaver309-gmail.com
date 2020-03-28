using System;
using System.Runtime.CompilerServices;


namespace NF.HardwareLib
{
    public class ChipInformation
    {
       
        /// <summary>
        /// Gets the chip flash size and type embedded or external
        /// </summary>
        public static byte[] GetFlashInfo
        {
          get
            {
                byte[] _buffer = new byte[50];
                    
                NativeGetFlashInfo(_buffer);
                
                return _buffer;
            }
        }


        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void NativeGetFlashInfo(byte[] data);

        /// <summary>
        /// Gets the chips features 
        /// </summary>
        public static byte[] GetFeatures
        {
            get
            {
                byte[] _buffer = new byte[50];

                NativeGetFeatures(_buffer);

                return _buffer;
            }
        }


        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void NativeGetFeatures(byte[] data);

        
        /// <summary>
        /// Gets the chips revision number 
        /// </summary>
        public static byte[] GetRevisionNumber
        {
            get
            {
                byte[] _buffer = new byte[50];

                NativeGetRevisionNumber(_buffer);

                return _buffer;
            }
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void NativeGetRevisionNumber(byte[] data);


    }
}
