<?php
header('Access-Control-Allow-Origin:*');
header('Content-Type: application/json');

include_once('../../Config/db.php');
include_once('../../Model/Account.php');
include_once('../Common.php');

$_POST = json_decode(file_get_contents('php://input'), true);

$db = new Database();
$account = new Account($db->connect());

$account->username = isset($_POST["username"]) ? $_POST["username"] : die();
$account->password = isset($_POST["password"]) ? $_POST["password"] : die();

$status = $account->checkUser($account->username, $account->password);

$array = [];

if ($status == 1) {
    $array = array(
        "status" => $SUCCESS,
        "data" => array(
            "userID" => $account->userID,
            "username" => $account->username,
            "role" => $account->role
        ),
        "message" => ""
    );
} else if ($status == 2) {
    $array = array(
        "status" => $FAIL,
        "message" => ""
    );
}
echo json_encode($array);
