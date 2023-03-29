<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catering
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(catering))
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.lblCatering = New System.Windows.Forms.Label()
        Me.lblStarMarket = New System.Windows.Forms.Label()
        Me.grpFood = New System.Windows.Forms.GroupBox()
        Me.grpPay = New System.Windows.Forms.GroupBox()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.btnCaluculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblLoyalPoints = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radWraps = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radSausage = New System.Windows.Forms.RadioButton()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.lblOderDetails = New System.Windows.Forms.Label()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFood.SuspendLayout()
        Me.grpPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlatter
        '
        Me.picPlatter.Image = CType(resources.GetObject("picPlatter.Image"), System.Drawing.Image)
        Me.picPlatter.Location = New System.Drawing.Point(430, 12)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(337, 213)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatter.TabIndex = 0
        Me.picPlatter.TabStop = False
        '
        'lblCatering
        '
        Me.lblCatering.AutoSize = True
        Me.lblCatering.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatering.Location = New System.Drawing.Point(109, 12)
        Me.lblCatering.Name = "lblCatering"
        Me.lblCatering.Size = New System.Drawing.Size(156, 39)
        Me.lblCatering.TabIndex = 1
        Me.lblCatering.Text = "Catering"
        '
        'lblStarMarket
        '
        Me.lblStarMarket.AutoSize = True
        Me.lblStarMarket.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarMarket.Location = New System.Drawing.Point(100, 51)
        Me.lblStarMarket.Name = "lblStarMarket"
        Me.lblStarMarket.Size = New System.Drawing.Size(134, 25)
        Me.lblStarMarket.TabIndex = 2
        Me.lblStarMarket.Text = "Star Market"
        '
        'grpFood
        '
        Me.grpFood.BackColor = System.Drawing.Color.FloralWhite
        Me.grpFood.Controls.Add(Me.radFruit)
        Me.grpFood.Controls.Add(Me.radSausage)
        Me.grpFood.Controls.Add(Me.radVeggie)
        Me.grpFood.Controls.Add(Me.radWraps)
        Me.grpFood.Controls.Add(Me.radCheese)
        Me.grpFood.Location = New System.Drawing.Point(35, 97)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(285, 183)
        Me.grpFood.TabIndex = 3
        Me.grpFood.TabStop = False
        '
        'grpPay
        '
        Me.grpPay.BackColor = System.Drawing.Color.FloralWhite
        Me.grpPay.Controls.Add(Me.radPickup)
        Me.grpPay.Controls.Add(Me.radPrePay)
        Me.grpPay.Location = New System.Drawing.Point(86, 315)
        Me.grpPay.Name = "grpPay"
        Me.grpPay.Size = New System.Drawing.Size(170, 80)
        Me.grpPay.TabIndex = 4
        Me.grpPay.TabStop = False
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(100, 437)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(125, 24)
        Me.lblPay.TabIndex = 5
        Me.lblPay.Text = "Please Pay: "
        '
        'btnCaluculate
        '
        Me.btnCaluculate.BackColor = System.Drawing.Color.Wheat
        Me.btnCaluculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaluculate.Location = New System.Drawing.Point(447, 345)
        Me.btnCaluculate.Name = "btnCaluculate"
        Me.btnCaluculate.Size = New System.Drawing.Size(113, 29)
        Me.btnCaluculate.TabIndex = 6
        Me.btnCaluculate.Text = "Calculate"
        Me.btnCaluculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Wheat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(631, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 29)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblLoyalPoints
        '
        Me.lblLoyalPoints.AutoSize = True
        Me.lblLoyalPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyalPoints.Location = New System.Drawing.Point(460, 272)
        Me.lblLoyalPoints.Name = "lblLoyalPoints"
        Me.lblLoyalPoints.Size = New System.Drawing.Size(120, 20)
        Me.lblLoyalPoints.TabIndex = 8
        Me.lblLoyalPoints.Text = "Loyalty Points"
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(638, 266)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(45, 26)
        Me.txtPoints.TabIndex = 9
        Me.txtPoints.Text = "99"
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Checked = True
        Me.radCheese.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCheese.Location = New System.Drawing.Point(24, 19)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(215, 21)
        Me.radCheese.TabIndex = 0
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Gourmet Cheese $49.99"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radWraps
        '
        Me.radWraps.AutoSize = True
        Me.radWraps.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWraps.Location = New System.Drawing.Point(24, 52)
        Me.radWraps.Name = "radWraps"
        Me.radWraps.Size = New System.Drawing.Size(215, 21)
        Me.radWraps.TabIndex = 1
        Me.radWraps.Text = "Pinwheel Wraps $59.99"
        Me.radWraps.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVeggie.Location = New System.Drawing.Point(24, 83)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(143, 21)
        Me.radVeggie.TabIndex = 2
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radSausage
        '
        Me.radSausage.AutoSize = True
        Me.radSausage.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSausage.Location = New System.Drawing.Point(24, 114)
        Me.radSausage.Name = "radSausage"
        Me.radSausage.Size = New System.Drawing.Size(251, 21)
        Me.radSausage.TabIndex = 3
        Me.radSausage.Text = "Sausage and Cheese $49.99"
        Me.radSausage.UseVisualStyleBackColor = True
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruit.Location = New System.Drawing.Point(24, 145)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(134, 21)
        Me.radFruit.TabIndex = 4
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Checked = True
        Me.radPrePay.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(7, 20)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(89, 21)
        Me.radPrePay.TabIndex = 0
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickup.Location = New System.Drawing.Point(7, 44)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(161, 21)
        Me.radPickup.TabIndex = 1
        Me.radPickup.Text = "Pay upon Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'lblOderDetails
        '
        Me.lblOderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOderDetails.Location = New System.Drawing.Point(251, 437)
        Me.lblOderDetails.Name = "lblOderDetails"
        Me.lblOderDetails.Size = New System.Drawing.Size(516, 55)
        Me.lblOderDetails.TabIndex = 10
        Me.lblOderDetails.Text = "Order Details"
        '
        'catering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(779, 501)
        Me.Controls.Add(Me.lblOderDetails)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblLoyalPoints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCaluculate)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.grpPay)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.lblStarMarket)
        Me.Controls.Add(Me.lblCatering)
        Me.Controls.Add(Me.picPlatter)
        Me.Name = "catering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFood.ResumeLayout(False)
        Me.grpFood.PerformLayout()
        Me.grpPay.ResumeLayout(False)
        Me.grpPay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblStarMarket As Label
    Friend WithEvents grpFood As GroupBox
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radSausage As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radWraps As RadioButton
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents grpPay As GroupBox
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents lblPay As Label
    Friend WithEvents btnCaluculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblLoyalPoints As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents lblOderDetails As Label
End Class
