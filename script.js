function showHide(id)
{
    document.getElementById(id).style.display = (document.getElementById(id).style.display == 'block' ? 'none' : 'block');
}

function markInvalid(id, condition)
{
    if(!condition)
        document.getElementById(id).style.backgroundColor = "#D77777";
    else
        document.getElementById(id).style.backgroundColor = "";
}

function generatePassword()
{
    var name = document.getElementById('name').value;
    var tid = parseInt(document.getElementById('tid').value);
    var money = parseInt(document.getElementById('money').value);
    var korean = (document.getElementById('kor').checked ? true : false);
    
    var validName = isValidName(name, korean);
    var validTid = isValidTid(tid);
    var validAmountOfMoney = isValidAmountOfMoney(money);

    markInvalid("name", validName);
    markInvalid("tid", validTid);
    markInvalid("money", validAmountOfMoney);
    
    if(validName && validTid && validAmountOfMoney)
        document.getElementById('password').innerHTML = getPassword(name, tid, money, korean);
    else
        document.getElementById('password').innerHTML = "Invalid";
}