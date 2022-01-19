$((function () {
    var url;
    var redirectUrl;
    var target;

    $('body').append(`
                  <form method="post" asp-action="Delete">
                    <div class="modal fade" id="deleteModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                        <div class="modal-header">
                            <div class="col">
                               <h4>Confirm<h4/>
                            </div>
                            <div class="col">
                                <button type="button" class="close float-right" data-dismiss="modal" aria-label="Close">
                                 <i class="far fa-window-close" aria-hidden="true">&times;</i>
                                </button>
                            </div>                           
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-12">
                                   <span class="delete-modal-body"></span>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-primary" data-dismiss="modal" id="cancel-delete">Cancel</button>
                            <button type="submit" class="btn btn-danger" id="confirm-delete">Delete</button>
                        </div>
                        </div>
                    </div>
                    </div>
                 </form>`);


    $(".delete").on('click', (e) => {
        e.preventDefault();

        target = e.target;
        var Id = $(target).data('id');
        var controller = $(target).data('controller');
        var action = $(target).data('action');
        var bodyMessage = $(target).data('body-message');
        redirectUrl = $(target).data('redirect-url');

        url = "/" + controller + "/" + action + "?Id=" + Id;
        $(".delete-modal-body").text(bodyMessage);
        $("#deleteModal").modal('show');
    });

    $("#confirm-delete").on('click', () => {
        $.get(url)
            .done((result) => {
                if (!redirectUrl) {
                    return $(target).parent().parent().hide("slow");
                }
                window.location.href = redirectUrl;
            })
            .fail((error) => {
                if (redirectUrl)
                    window.location.href = redirectUrl;
            }).always(() => {
                $("#deleteModal").modal('hide');
            });
    });

}()));
