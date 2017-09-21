' <auto-generated>
'     This code was generated by the .NET ToolStrip Customizer.
'     http://toolstripcustomizer.codeplex.com/
' </auto-generated>

Imports System.Drawing
Imports System.Windows.Forms

Namespace MyNamespace
    Class CustomColorTable
        Inherits ProfessionalColorTable
        Public Overrides ReadOnly Property ButtonSelectedHighlight() As Color
            Get
                Return ButtonSelectedGradientMiddle
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonSelectedHighlightBorder() As Color
            Get
                Return ButtonSelectedBorder
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonPressedHighlight() As Color
            Get
                Return ButtonPressedGradientMiddle
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonPressedHighlightBorder() As Color
            Get
                Return ButtonPressedBorder
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonCheckedHighlight() As Color
            Get
                Return ButtonCheckedGradientMiddle
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonCheckedHighlightBorder() As Color
            Get
                Return ButtonSelectedBorder
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonPressedBorder() As Color
            Get
                Return ButtonSelectedBorder
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonSelectedBorder() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonCheckedGradientBegin() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonCheckedGradientMiddle() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonCheckedGradientEnd() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonSelectedGradientBegin() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonSelectedGradientMiddle() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonSelectedGradientEnd() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonPressedGradientBegin() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonPressedGradientMiddle() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ButtonPressedGradientEnd() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property CheckBackground() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property CheckSelectedBackground() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property CheckPressedBackground() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property GripDark() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property GripLight() As Color
            Get
                Return Color.FromName("White")
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientBegin() As Color
            Get
                Return Color.FromArgb(Skins.applauncherbackgroundcolour.ToArgb)
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientMiddle() As Color
            Get
                Return Color.FromArgb(Skins.applauncherbackgroundcolour.ToArgb)
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientEnd() As Color
            Get
                Return Color.FromArgb(Skins.applauncherbackgroundcolour.ToArgb)
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginRevealedGradientBegin() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginRevealedGradientMiddle() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginRevealedGradientEnd() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property MenuStripGradientBegin() As Color
            Get
                If Skins.applauncher Is Nothing Then
                    Return Color.FromArgb(Skins.applauncherbuttoncolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuStripGradientEnd() As Color
            Get
                If Skins.applauncher Is Nothing Then
                    Return Color.FromArgb(Skins.applauncherbuttoncolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelected() As Color
            Get
                Return Color.FromArgb(Skins.applaunchermouseovercolour.ToArgb)
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemBorder() As Color
            Get
                If Skins.applauncher Is Nothing Then
                    Return Color.FromArgb(Skins.applaunchermouseovercolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuBorder() As Color
            Get
                If Skins.applauncher Is Nothing Then
                    Return Color.FromArgb(Skins.applauncherbackgroundcolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin() As Color
            Get
                If Skins.applauncher Is Nothing Then
                    Return Color.FromArgb(Skins.applaunchermouseovercolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd() As Color
            Get
                If Skins.applauncher Is Nothing Then
                    Return Color.FromArgb(Skins.applaunchermouseovercolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemPressedGradientBegin() As Color
            Get
                'remember this is for clicking the button, the below must be changed in the future
                If Skins.applauncherclick Is Nothing Then
                    Return Color.FromArgb(Skins.applauncherbuttonclickedcolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemPressedGradientMiddle() As Color
            Get
                If Skins.applauncherclick Is Nothing Then
                    Return Color.FromArgb(Skins.applauncherbuttonclickedcolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemPressedGradientEnd() As Color
            Get
                If Skins.applauncherclick Is Nothing Then
                    Return Color.FromArgb(Skins.applauncherbuttonclickedcolour.ToArgb)
                Else
                    Return Color.Transparent
                End If
            End Get
        End Property
        Public Overrides ReadOnly Property RaftingContainerGradientBegin() As Color
            Get
                Return Color.FromName("ButtonFace")
            End Get
        End Property
        Public Overrides ReadOnly Property RaftingContainerGradientEnd() As Color
            Get
                Return Color.FromArgb(255, 252, 252, 252)
            End Get
        End Property
        Public Overrides ReadOnly Property SeparatorDark() As Color
            Get
                Return Color.FromName("Black")
            End Get
        End Property
        Public Overrides ReadOnly Property SeparatorLight() As Color
            Get
                Return Color.FromName("ButtonHighlight")
            End Get
        End Property
        Public Overrides ReadOnly Property StatusStripGradientBegin() As Color
            Get
                Return Color.FromName("ButtonFace")
            End Get
        End Property
        Public Overrides ReadOnly Property StatusStripGradientEnd() As Color
            Get
                Return Color.FromArgb(255, 252, 252, 252)
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripBorder() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripDropDownBackground() As Color
            Get
                Return Color.FromArgb(Skins.applauncherbackgroundcolour.ToArgb)
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripGradientBegin() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripGradientMiddle() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripGradientEnd() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripContentPanelGradientBegin() As Color
            Get
                Return Color.FromName("ButtonFace")
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripContentPanelGradientEnd() As Color
            Get
                Return Color.FromArgb(255, 252, 252, 252)
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripPanelGradientBegin() As Color
            Get
                Return Color.FromName("ButtonFace")
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripPanelGradientEnd() As Color
            Get
                Return Color.FromArgb(255, 252, 252, 252)
            End Get
        End Property
        Public Overrides ReadOnly Property OverflowButtonGradientBegin() As Color
            Get
                Return Color.FromArgb(255, 245, 245, 245)
            End Get
        End Property
        Public Overrides ReadOnly Property OverflowButtonGradientMiddle() As Color
            Get
                Return Color.FromArgb(255, 242, 242, 242)
            End Get
        End Property
        Public Overrides ReadOnly Property OverflowButtonGradientEnd() As Color
            Get
                Return Color.FromName("Gray")
            End Get
        End Property
    End Class
End Namespace