using System;
using System.Runtime.InteropServices;
namespace GettingAllUsers
{
    public class NetworkAPI
    {
        // USER_INFO_1: estructura para guardar la información de usuario obtenida
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct USER_INFO_1
        {
            public string usri1_name;
            public string usri1_password;
            public int usri1_password_age;
            public int usri1_priv;
            public string usri1_home_dir;
            public string comment;
            public int usri1_flags;
            public string usri1_script_path;
        }

        // USER_INFO_0 - Estructura para contener solo nombres de usuario 
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct USER_INFO_0
        {
            public String Username;
        }
        // NetUserAdd: para agregar usuarios a una máquina o red local
        [DllImport("Netapi32.dll")]
        public extern static int NetUserAdd([MarshalAs(UnmanagedType.LPWStr)] string servername, int level, ref USER_INFO_1 buf, int parm_err);
       // NetUserDel: para eliminar usuarios de una máquina o red local 
        [DllImport("Netapi32.dll")]
        public extern static int NetUserDel([MarshalAs(UnmanagedType.LPWStr)] string servername, [MarshalAs(UnmanagedType.LPWStr)] string username);
        // NetUserGetInfo - Regresa a una estructura Información sobre el usuario especificado  
        [DllImport("Netapi32.dll")]
        public extern static int NetUserGetInfo([MarshalAs(UnmanagedType.LPWStr)] string servername, [MarshalAs(UnmanagedType.LPWStr)] string username, int level, out IntPtr bufptr);
        // NetUserSetInfo: nos permite modificar la información del usuario
        [DllImport("Netapi32.dll")]
        public extern static int NetUserSetInfo([MarshalAs(UnmanagedType.LPWStr)] string servername, [MarshalAs(UnmanagedType.LPWStr)] string username, int level, ref USER_INFO_1 buf, int error);
        // NetUserChangePassword - Allows us to change a users password providing we have it  
        [DllImport("Netapi32.dll")]
        public extern static int NetUserChangePassword([MarshalAs(UnmanagedType.LPWStr)] string domainname, [MarshalAs(UnmanagedType.LPWStr)] string username, [MarshalAs(UnmanagedType.LPWStr)] string oldpassword, [MarshalAs(UnmanagedType.LPWStr)] string newpassword);
        // NetUserEnum: obtiene una lista de todos los usuarios en la máquina o red local  
        [DllImport("Netapi32.dll")]
        public extern static int NetUserEnum(string servername, int level, int filter, out IntPtr bufptr, int prefmaxlen, out int entriesread, out int totalentries, out int resume_handle);
        // NetAPIBufferFree: se utiliza para borrar el búfer de red después de NetUserEnum  
        [DllImport("Netapi32.dll")]
        public extern static int NetApiBufferFree(IntPtr Buffer);
        public NetworkAPI()
        {
        //  
        //   TODO: Agregar lógica de constructor aquí
        //  
        }
    }
   
}