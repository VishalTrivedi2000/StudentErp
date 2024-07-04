function renderLowerPartial(idx) {
    $.ajax(
        {
            url: "/RWA/RWARegistrationView?stepReCheck=" + (idx + 1),
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (result) {
                $('#partialContainer').html(result);
            }
            , error: function (xhr, status) { alert(status); }
        })
}