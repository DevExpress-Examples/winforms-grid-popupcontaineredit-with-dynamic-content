<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1305)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


