﻿using UnityEngine;
using System.Collections;

namespace CatLib.Contracts.Network
{

    /// <summary>
    /// 网络服务
    /// </summary>
    public interface INetwork
    {
        T Create<T>(string aisle) where T : IConnector;

        void Disconnect(string aisle);

        T Get<T>(string aisle) where T : IConnector;
    }
}