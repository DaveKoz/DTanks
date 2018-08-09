﻿using System;
using UnityEngine;

namespace DMarketSDK.Market.SpriteManager
{
    public interface ISpriteItemContainer
    {
        event Action<string, Sprite> SpriteUpdated;

        Sprite GetSprite(string url);

        void ReturnSprite(string url);
    }
}