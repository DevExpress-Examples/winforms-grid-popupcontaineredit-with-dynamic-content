# How to implement the in-place PopupContainerEdit with the dynamic popup content


<p>To accomplish this task, create a separate UserControl for each pop-up window and provide necessary functionality to bind its editors to data and retrieve EditValue. Within the QueryPopup event of the RepositoryItemPopupContainerEdit, you can dynamically add necessary UserControl to the PopupContainerControl.</p>

<br/>


