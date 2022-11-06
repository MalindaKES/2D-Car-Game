using UnityEngine;

namespace Masamune {
   /// <summary>
   /// Class TextIconApplicator.
   /// Implements the <see cref="UnityEngine.MonoBehaviour" />
   /// </summary>
   /// <seealso cref="UnityEngine.MonoBehaviour" />
   [AddComponentMenu( "Masamune/IconFont/Text Icon Applicator" ), DisallowMultipleComponent, ExecuteInEditMode, RequireComponent( typeof( UnityEngine.UI.Text ) )]
   public class TextIconApplicator : MonoBehaviour {

      /// <summary>
      /// The text
      /// </summary>
      [SerializeField]
      public UnityEngine.UI.Text text;

      /// <summary>
      /// Gets or sets the icon.
      /// </summary>
      /// <value>The icon.</value>
      public string icon {
         get => this._icon;
         set {
            this._icon = value;
            this.Repaint( );
         }
      }
      [SerializeField]
      private string _icon;

      /// <summary>
      /// Awakes this instance.
      /// </summary>
      private void Awake( ) {
         if( this.text == null ) this.text = this.GetComponent<UnityEngine.UI.Text>( );
         this.Repaint( );
      }
      /// <summary>
      /// Called when [validate].
      /// </summary>
      private void OnValidate( ) {
         this.Repaint( );
      }

      /// <summary>
      /// Repaints this instance.
      /// </summary>
      public void Repaint( ) {
         if( this.text == null || this.icon.IsNullOrEmpty( ) ) return;
         Icon icon = Icon.Get( this.icon );
         if( icon == null ) return;
         this.text.font = icon;
         this.text.text = icon;
      }
   }
}
