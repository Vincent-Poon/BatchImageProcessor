// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.ShellContextMenu.#SHGetDesktopFolder(System.IntPtr&)")]
[assembly:
    SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "2",
        Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.ShellContextMenu.#StrRetToBuf(System.IntPtr,System.IntPtr,System.Text.StringBuilder,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.ShellContextMenu.#StrRetToBuf(System.IntPtr,System.IntPtr,System.Text.StringBuilder,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.ShellContextMenu.#TrackPopupMenuEx(System.IntPtr,AndreasJohansson.Win32.Shell.ShellContextMenu+TPM,System.Int32,System.Int32,System.IntPtr,System.IntPtr)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.ShellContextMenu.#CreatePopupMenu()")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.ShellContextMenu.#DestroyMenu(System.IntPtr)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.ShellContextMenu.#GetMenuDefaultItem(System.IntPtr,System.Boolean,System.UInt32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.HookEventArgs.#wParam")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable", Scope = "type",
        Target = "AndreasJohansson.Win32.Shell.LocalWindowsHook")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.LocalWindowsHook.#m_hhook")]
[assembly:
    SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.LocalWindowsHook.#SetWindowsHookEx(AndreasJohansson.Win32.Shell.HookType,AndreasJohansson.Win32.Shell.LocalWindowsHook+HookProc,System.IntPtr,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.LocalWindowsHook.#SetWindowsHookEx(AndreasJohansson.Win32.Shell.HookType,AndreasJohansson.Win32.Shell.LocalWindowsHook+HookProc,System.IntPtr,System.Int32)"
        )]
[assembly:
    SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.LocalWindowsHook.#UnhookWindowsHookEx(System.IntPtr)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.LocalWindowsHook.#UnhookWindowsHookEx(System.IntPtr)")]
[assembly:
    SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.LocalWindowsHook.#CallNextHookEx(System.IntPtr,System.Int32,System.IntPtr,System.IntPtr)"
        )]
[assembly:
    SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "return",
        Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.LocalWindowsHook.#CallNextHookEx(System.IntPtr,System.Int32,System.IntPtr,System.IntPtr)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member",
        Target =
            "AndreasJohansson.Win32.Shell.LocalWindowsHook.#CallNextHookEx(System.IntPtr,System.Int32,System.IntPtr,System.IntPtr)"
        )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly", Scope = "member",
        Target = "BatchImageProcessor.Controls.SplitButton.#Click")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "AndreasJohansson.Win32.Shell.HookEventArgs.#lParam")]