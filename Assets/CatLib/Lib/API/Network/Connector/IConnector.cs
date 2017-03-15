﻿using System.Collections;

namespace CatLib.API.Network
{

    public interface IConnector
    {
        
        string Name { get; set; }

        void SetConfig(Hashtable hashtable);

        IEnumerator StartServer();

        void Destroy();
        
    }

}
