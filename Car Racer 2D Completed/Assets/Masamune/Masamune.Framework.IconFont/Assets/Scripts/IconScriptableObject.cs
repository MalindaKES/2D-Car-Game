using System.Collections.Generic;
using UnityEngine;

namespace Masamune.Sample.IconFont {
   /// <summary>
   /// Class IconScriptableObject.
   /// Implements the <see cref="UnityEngine.ScriptableObject" />
   /// </summary>
   /// <seealso cref="UnityEngine.ScriptableObject" />
   [CreateAssetMenu( menuName = "Masamune Sample/IconFont/Icon Sample", fileName = "IconSample", order = -500 )]
   public class IconScriptableObject : ScriptableObject {

      /// <summary>
      /// The key
      /// </summary>
      [SerializeField]
      public string icon;

   }
}
