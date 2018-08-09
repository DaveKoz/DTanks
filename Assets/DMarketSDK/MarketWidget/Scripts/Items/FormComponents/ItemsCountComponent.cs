﻿using TMPro;
using UnityEngine;

namespace DMarketSDK.Market.Containers
{
    public sealed class ItemsCountComponent : ContainerComponentBase
    {
        private string _textFormat;

        [SerializeField]
        private TextMeshProUGUI _txtItemsFound;

        private void Awake()
        {
            _textFormat = _txtItemsFound.text;
        }

        protected override void OnModelChanged()
        {
            _txtItemsFound.text = string.Format(_textFormat, Model.TotalItemsCount);
        }
    }
}