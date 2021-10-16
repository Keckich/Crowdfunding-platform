
const LoadCommData = () => {
    var commentBlock = '';
    let id = window.location.pathname.split('/').pop();
    $.ajax({
        url: '/Home/GetComments',
        method: 'GET',
        success: (result) => {
            $.each(result, (k, v) => {
                if (v.campaignId == id) {
                    commentBlock += `<div class="col-8">
                                            <div>
                                                <time>${v.postDate}</time>
                                                <p>${v.author}</p>
                                            </div>
                                            <div>
                                                ${v.content}
                                            </div>
                                            <hr/>
                                        </div>`
                }
            });
            $("#comments").html(commentBlock);       
        },
        error: (error) => {
            console.log('Error:' + error);
        }
    });
}

$(() => {
    var connection = new signalR.HubConnectionBuilder().withUrl("/CommentHub").build();
    connection.on("LoadComments", () => {
        LoadCommData();
    });
    LoadCommData();
    connection.start().catch(err => console.error(err.toString()));
});