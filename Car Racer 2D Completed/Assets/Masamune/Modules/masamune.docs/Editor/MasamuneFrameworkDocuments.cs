using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

/// <summary>
/// Class MasamuneFrameworkDocuments.
/// </summary>
public class MasamuneFrameworkDocuments : EditorWindow {
   /// <summary>
   /// Show the EditorWindow window.
   /// </summary>
   [MenuItem( "Masamune/Masamune Framework", false, 150 )]
   public new static void Show( ) {
      MasamuneFrameworkDocuments wnd = GetWindow<MasamuneFrameworkDocuments>( );
      wnd.titleContent = new GUIContent( "Masamune Framework" );
   }
   private void OnEnable( ) {
      this.ApplyStyle( );
      Toggle toggle = this.rootVisualElement.Q<Toggle>( "not_show_at_startup" );
      if( toggle == null ) return;
      toggle.value = EditorPrefs.HasKey( "MasamuneIsHideMasamuneFrameworkDocuments" );
      toggle.RegisterValueChangedCallback( ( evt ) => {
         if( evt.newValue ) EditorPrefs.SetBool( "MasamuneIsHideMasamuneFrameworkDocuments", true );
         else EditorPrefs.DeleteKey( "MasamuneIsHideMasamuneFrameworkDocuments" );
      } );
   }

   [InitializeOnLoadMethod]
   static void ShowOnInitialize( ) {
      if( EditorPrefs.HasKey( "MasamuneIsHideMasamuneFrameworkDocuments" ) ) return;
      EditorApplication.delayCall += Show;
   }
}