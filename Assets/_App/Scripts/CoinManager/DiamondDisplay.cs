using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondDisplay : MonoBehaviour
{
   public TextMeshProUGUI diamondTmp;
   [SerializeField] private IntVariable PlayerCoinTotal;

   void OnValidated()
   {
      diamondTmp = GetComponent<TextMeshProUGUI>();
   }

   private void Update()
   {
      diamondTmp.SetText(PlayerCoinTotal.Value.ToString());
   }
}
