function LoadPage() {
    setTimeout(function () {
        window.location.href = 'General/Home';
    }, 5000);
}
function AddAnnouncementButtonNavigation() {
    window.location.href = '/Firm/Login';
}
function FindJobButtonNavigation() {
    window.location.href = '/User/Login';
} 
function SwapToUserPage() {
    window.location.href = '/User/Login';
} 
function BackToHomePage() {
    window.location.href = '/General/Home';
}
function LoadFirmLoggedHomePage() {
    window.location.href = '/FirmLogged/Home';
}
function LoadAdminPage() {
    window.location.href = '/AdminLogged/Categories';
}
function FirmLoggedAddAnnoucementNavigation() {
    window.location.href = '/FirmLogged/AddAnnouncement';
}
function FirmLoggedNotificationsNavigation() {
    window.location.href = '/FirmLogged/Notifications';
}
function SwapToFirmPage() {
    window.location.href = '/Firm/Login';
} 
function LoadUserPage() {
    window.location.href = '/UserLogged/Home';
}
function UserLoggedNotificationsNavigation() {
    window.location.href = '/FirmLogged/Notifications';
}