using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.GameObjects.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Client.Interface.Game
{
    public class PlayerRespawnWindow : Base
    {
        public Canvas GameCanvas;
        public bool RequestingRespawn = false;

        private ImagePanel Background;

        private RichLabel DeathText;
        private Label DeathTextTemplate;

        private Button NormalRespawnButton;
        private Button LeaveInstanceButton;
        private Button DungeonRespawnButton;

        public PlayerRespawnWindow(Canvas gameCanvas)
        {
            GameCanvas = gameCanvas;

            Background = new ImagePanel(GameCanvas, "PlayerRespawnWindow");

            DeathTextTemplate = new Label(Background, "EventDialogLabel");
            DeathText = new RichLabel(Background);

            NormalRespawnButton = new Button(Background, "NormalRespawnButton")
            {
                Text = Strings.RespawnWindow.RespawnButton,
            };
            NormalRespawnButton.Clicked += NormalRespawnButton_Clicked;

           
            Interface.InputBlockingElements.Add(Background);

            Background.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            SetType(DeathType.Safe);
        }

        public void Update()
        {
            Background.IsHidden = !Globals.Me?.IsDead ?? true;
            if (Background.IsHidden)
            {
                return;
            }

            Graphics.DrawGameTexture(Graphics.Renderer.GetWhiteTexture(), new FloatRect(0, 0, 1, 1), Graphics.CurrentView, new Color(150, 0, 0, 0));

            NormalRespawnButton.IsDisabled = RequestingRespawn;

        }

        public void SetType(DeathType deathType)
        {
            DeathText.ClearText();
            NormalRespawnButton.Hide();
            DeathText.Width = Background.Width - (Background.Padding.Left + Background.Padding.Right);
            DeathText.Height = Background.Height - (Background.Padding.Bottom + Background.Padding.Top);
            if (deathType == DeathType.PvE)
            {
                DeathText.AddText(Strings.RespawnWindow.DeathPvE.ToString(), DeathTextTemplate);
                NormalRespawnButton.Show();
                return;
            }
            if (deathType == DeathType.PvP)
            {
                DeathText.AddText(Strings.RespawnWindow.DeathItems.ToString(), DeathTextTemplate);
                NormalRespawnButton.Show();
                return;
            }
            if (deathType == DeathType.Safe)
            {
                DeathText.AddText(Strings.RespawnWindow.DeathSafe, DeathTextTemplate);
                NormalRespawnButton.Show();
                return;
            }
            DeathText.AddText(Strings.RespawnWindow.DeathSafe, DeathTextTemplate);
        }

        #region Handlers
        void NormalRespawnButton_Clicked(Base sender, ClickedEventArgs arguments)
        {
            RequestRespawn();
        }

       
        private void RequestRespawn()
        {
            RequestingRespawn = true;
            PacketSender.SendRequestRespawn();
        }

      

        public void ServerRespawned()
        {
            RequestingRespawn = false;
        }
        #endregion
    }
}
