﻿(function(self, $, _document, _console, _indexService, undefined) {
    "use strict";

    var $doc;
    var $html;
    var $config;
    var loadingVar;


    self.Init = function(config) {
        loadingAnimation();
        digestConfig(config);
        initImpl(config);

    };

    function digestConfig(config) {
        $config = config;
    };

    function initImpl(config) {
        initialListeners();
    }

    function initialListeners() {

        $(_document).on("click",".goToRoomsBtn",
            function() {
                var categId = $(this).parents("li").attr("data-categ-id");

           
                displayRoomsByCateg();
                populateDataTable(categId);
            });

        $(_document).on("click", ".roominBtn", function () {
            var roomId = $(this).attr("id");

            $.ajax({
                method: "get",
                url: `/api/ChatEngineApi/Chatengine?roomId=${roomId}`,

                success: function (data) {
                    if (data) {
                        window.location = "/ChatEngine/ChatStart?roomid=" + roomId;
                    } else {
                        alert("Room Anavailable");
                    }

                },
                fail: function(jqXHR, textStatus, error) {
                    if (jqXHR === 400) {
                        alert("Room unavailable for the time been");
                    }
                    console.log(jqXHR);
                    console.log(textStatus);
                    console.log(error);
                }

            });
        });

    }
    function displayRoomsByCateg() {
        $("#container-categories-img-list").fadeOut(200);
        $("#roomsByCategory").fadeIn(300);
        $("#redirectPanel").fadeIn(300);
    }

    function populateDataTable(id) {

        const $tablebyGenre = $("#ChatRoomsByGenre").DataTable({
            ajax: {
                url: `/api/RoomList/GetRoomsForSpecificGenre?id=${id}`,
                dataSrc: ""
            },
            columns: [
                {
                    data: "Name"
                },
                {
                    data: "Genre"
                },
                {
                    data: "Description"
                },
                {
                    data: "DateExpired",
                    render: function (data) {
                        var dateString = data;
                        var yearDate = dateString.substring(0, dateString.indexOf("T"));
                        var time = dateString.substring(dateString.indexOf("T") + 1, dateString.length - 4);
                        return yearDate + "  " + time;
                    }

                },
                {
                    data: "Id",
                    render: function (data, type, room) {
                        if (room.Active) {
                            return `<button class='btn btn-success roominBtn' id='${data}'>Enter Room</button>`;
                        } else {
                            return `<button class='btn btn-warning roominBtn disabled' id='${data}'>Unavailable</button>`;
                        }
                        
                    }
                }
            ]
        });
    }


    function loadingAnimation() {
        loadingVar = setTimeout(showPage, 1000);
    }



    function showPage() {
        $("#loader").css("display", "none");
        $("#IndexContainer").css("display", "block");
    }

}(window.IndexController = window.IndexController || {}, jQuery, document, console, IndexService));