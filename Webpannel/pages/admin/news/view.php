<?php
/**
 * Created by PhpStorm.
 * User: hubert_i
 * Date: 14/06/16
 * Time: 20:12
 */
    $id = $match['params']['id'];
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="description" content="launcherPanel">
        <meta name="author" content="Leo HUBERT">

        <link rel="shortcut icon" href="/assets/images/favicon_1.ico">

        <title><?php echo $site;?> panel</title>

        <link href="/assets/plugins/jquery-circliful/css/jquery.circliful.css" rel="stylesheet" type="text/css" />

        <link href="/assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <link href="/assets/css/core.css" rel="stylesheet" type="text/css" />
        <link href="/assets/css/components.css" rel="stylesheet" type="text/css" />
        <link href="/assets/css/icons.css" rel="stylesheet" type="text/css" />
        <link href="/assets/css/pages.css" rel="stylesheet" type="text/css" />
        <link href="/assets/css/menu.css" rel="stylesheet" type="text/css" />
        <link href="/assets/css/responsive.css" rel="stylesheet" type="text/css" />

        <link href="/assets/plugins/sweetalert/dist/sweetalert.css" rel="stylesheet" type="text/css">
        <link href="/assets/plugins/jquery-circliful/css/jquery.circliful.css" rel="stylesheet" type="text/css" />

        <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
        <![endif]-->

        <script src="/assets/js/modernizr.min.js"></script>

    </head>



    <body onload="loadNews()">

        <!-- Navigation Bar-->
        <?php include "jointures/header_admin.php"?>
        <!-- End Navigation Bar-->

        <div class="wrapper">
            <div class="container">

                <!-- Page-Title -->
                <div class="row">
                    <div class="col-sm-12">
                        <h4 class="page-title">News control</h4>
                    </div>
                </div>

                <div class="col-sm-4">
                </div>
                <div class="col-sm-4 col-lg-4">
                    <div class="card-box widget-user">
                        <div>
                            <img src="/assets/images/news.png" class="img-responsive img-circle" alt="user">
                            <div class="wid-u-info">
                                <h3 class="m-b-5 font-25" id="news_title_label"></h3>
                                <h4 class="m-t-0 m-b-5" id="news_date_label"></h4>
                                <a href="" id="news_link_redirect"><button type="button" class="btn btn-primary btn-custom waves-effect w-md waves-light m-b-5"><div id="news_link_button"></div></button></a>
                                <br>
                                <button type="button" class="btn btn-danger btn-custom waves-effect w-md waves-light m-b-5" onclick="removeNews()">Remove this news</button>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-color panel-primary">
                        <div class="panel-heading">
                            <h3 class="panel-title">News control</h3>
                        </div>
                        <div class="panel-body">
                            <p>
                            <div class="form-group">
                                <div class="col-sm-4">
                                       <h3 class="panel-title">Create at: </h3>
                                </div>
                                <div class="col-sm-8">
                                     <span id="news_date"></span>
                                </div>
                                <br><br>
                                <div class="col-sm-12">
                                    <input type="text" class="form-control"  placeholder="News tittle" id="news_title">
                                </div>
                                <br>
                                <br>
                                <div class="col-sm-12">
                                    <input type="text" class="form-control"  placeholder="News redirect link" id="news_link">
                                </div>
                            </div>

                            </p>
                        </div>
                        <div class="panel-footer">
                            <button type="button" class="btn btn-success btn-custom waves-effect w-md waves-light m-b-5" onclick="saveNews()">Save</button>
                        </div>
                    </div>
                </div>


                <?php include "jointures/footer.php";?>

            </div> <!-- end container -->
        </div>
        <!-- End wrapper -->


        <script type="text/javascript">
            function loadNews() {
                $.post(
                    '/api/news/admin/get',
                    {
                        token : "<?php echo $_SESSION['token'];?>",
                        id : "<?php echo $id;?>"
                    },

                    function(data){
                        var obj = JSON.parse(data);

                        if (obj.status == 42)
                        {
                            document.getElementById("news_title").value = obj.title;
                            document.getElementById("news_link").value = obj.link;
                            document.getElementById("news_date").innerText = obj.date;
                            document.getElementById("news_link_redirect").href = obj.link;
                            document.getElementById("news_link_button").innerText = obj.link;
                            document.getElementById("news_title_label").innerText = obj.title;
                            document.getElementById("news_date_label").innerText = "Create at: " + obj.date;
                        }
                        else if (obj.status == 41)
                            window.location="/logout";
                        else
                            swal("Error...", obj.message, "error");
                    },

                    'text'
                );
            }
            function saveNews() {
                $.post(
                    '/api/news/admin/edit',
                    {
                        token : "<?php echo $_SESSION['token'];?>",
                        title : document.getElementById("news_title").value,
                        link : document.getElementById("news_link").value,
                        id : "<?php echo $id;?>"
                    },

                    function(data){
                        var obj = JSON.parse(data);

                        if (obj.status == 42)
                        {
                            $.Notification.notify('success','top right','Saved !', obj.message);
                            loadNews();
                        }
                        else if (obj.status == 41)
                            window.location="/logout";
                        else
                            swal("Error...", obj.message, "error");
                    },

                    'text'
                );
            }
            function removeNews() {
                swal({
                    title: "Are you sure?",
                    text: "You will not be able to recover this news!",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Yes, delete it!",
                    cancelButtonText: "No, cancel plx!",
                    closeOnConfirm: false,
                    closeOnCancel: false
                }, function(isConfirm){
                    if (isConfirm) {
                        $.post(
                            '/api/news/admin/remove',
                            {
                                token : "<?php echo $_SESSION['token'];?>",
                                id : "<?php echo $id;?>"
                            },

                            function(data){
                                var obj = JSON.parse(data);

                                if (obj.status == 42)
                                {
                                    swal("Deleted!", obj.message , "success");
                                    setInterval(function () {
                                        window.location = "/news";
                                    }, 1000);
                                }
                                else if (obj.status == 41)
                                    window.location="/logout";
                                else
                                    swal("Error...", obj.message, "error");
                            },

                            'text'
                        );
                    } else {
                        swal("Cancelled", "Deletion successfully canceled", "error");
                    }
                });
            }

        </script>


        <!-- jQuery  -->
        <script src="/assets/js/jquery.min.js"></script>
        <script src="/assets/js/bootstrap.min.js"></script>
        <script src="/assets/js/detect.js"></script>
        <script src="/assets/js/fastclick.js"></script>
        <script src="/assets/js/jquery.blockUI.js"></script>
        <script src="/assets/js/waves.js"></script>
        <script src="/assets/js/wow.min.js"></script>
        <script src="/assets/js/jquery.nicescroll.js"></script>
        <script src="/assets/js/jquery.scrollTo.min.js"></script>

        <!-- circliful Chart -->
        <script src="/assets/plugins/jquery-circliful/js/jquery.circliful.min.js"></script>
        <script src="/assets/plugins/jquery-sparkline/jquery.sparkline.min.js"></script>

        <!-- skycons -->
        <script src="/assets/plugins/skyicons/skycons.min.js" type="text/javascript"></script>

        <!-- Notifications -->
        <script src="/assets/plugins/notifyjs/dist/notify.min.js"></script>
        <script src="/assets/plugins/notifications/notify-metro.js"></script>

        <!-- Custom main Js -->
        <script src="/assets/js/jquery.core.js"></script>
        <script src="/assets/js/jquery.app.js"></script>

        <!-- Sweet-Alert  -->
        <script src="/assets/plugins/sweetalert/dist/sweetalert.min.js"></script>
        <script src="/assets/pages/jquery.sweet-alert.init.js"></script>

    </body>
</html>