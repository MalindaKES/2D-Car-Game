using UnityEditor;
using UnityEditor.Callbacks;

namespace UnityEngine.Style.Icon {
   [InitializeOnLoad]
   internal static class EditorFontAwesome {
      static EditorFontAwesome( ) {
         if( EditorApplication.isPlayingOrWillChangePlaymode ) return;
         EditorApplication.delayCall += Initizlie;
      }
      private static void Initizlie( ) {
         if( EditorApplication.isPlayingOrWillChangePlaymode ) return;
         FontAwesomeInfo.Initialize( );
      }
   }
}
