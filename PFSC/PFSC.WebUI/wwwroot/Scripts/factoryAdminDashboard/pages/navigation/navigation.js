$(function() {
    var navbarLinks = $('#sidebarnav').find('*[data-action]');
    var mainContainer = $('#maindDashboardContainer');

    navbarLinks.on('click',
        function(e) {
            var url = $(e.currentTarget).data('action');

            $.ajax({
                url: url,
                type: 'GET',
                dataType: 'html',
                //contentType: 'application/json; charset=utf-8',
                //data: JSON.stringify({ 'testsToRun': testsToRun }),
                cache: false,
                success: function (result) {
                    console.log(result);
                    mainContainer.html(result);
                },
                error: function (result) {
                }
            });
        });
})