using System.Collections.Generic;
using Alensia.Core.UI.Cursor;
using Alensia.Core.UI.Screen;
using UnityEngine;

namespace Alensia.Core.UI
{
    public interface IUIManager : IUIContextHolder
    {
        IReadOnlyList<IScreen> Screens { get; }

        Transform ScreenRoot { get; }

        CursorState CursorState { get; set; }

        CursorSet CursorSet { get; }

        string DefaultCursor { get; set; }

        IScreen FindScreen(string name);

        void ShowScreen(string name);

        void HideScreen(string name);
    }
}