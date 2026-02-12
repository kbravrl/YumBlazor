function ShowConfirmationModal() {
    bootstrap.Model.getOrCreateInstance(document.getElementById('exampleModal')).show();
}

function HideConfirmationModal() {
    bootstrap.Model.getOrCreateInstance(document.getElementById('exampleModal')).hide();
}