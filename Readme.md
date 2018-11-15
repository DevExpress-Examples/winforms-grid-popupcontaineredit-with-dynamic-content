<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q148684/Form1.cs) (VB: [Form1.vb](./VB/Q148684/Form1.vb))
* [GridDetailEditor.cs](./CS/Q148684/GridDetailEditor.cs) (VB: [GridDetailEditor.vb](./VB/Q148684/GridDetailEditor.vb))
* [Program.cs](./CS/Q148684/Program.cs) (VB: [Program.vb](./VB/Q148684/Program.vb))
* [SimpleDetailEditor.cs](./CS/Q148684/SimpleDetailEditor.cs) (VB: [SimpleDetailEditor.vb](./VB/Q148684/SimpleDetailEditor.vb))
<!-- default file list end -->
# How to implement the in-place PopupContainerEdit with the dynamic popup content


<p>To accomplish this task, create a separate UserControl for each pop-up window and provide necessary functionality to bind its editors to data and retrieve EditValue. Within the QueryPopup event of the RepositoryItemPopupContainerEdit, you can dynamically add necessary UserControl to the PopupContainerControl.</p>

<br/>


