let database = [];

function submitForm() {
  let ad 

  if (yas < 18) {
    alert("Yaşiniz 18-dən böyük olmalidir.");
    return false;
  }

  if (ad.length < 3) {
    alert("Adiniz 3 hərfdən az ola bilməz.");
    return false;
  }

  if (soyad.length < 3) {
    alert("Soyadiniz 3 hərfdən az ola bilməz.");
    return;
  }

  let newUser = {
    Ad: ad,
    Soyad: soyad,
    Yas: yas,
    Şifrə: sifre,
    Email: email,
    Cins: cins,
    Hobbilər: hobiler,
  };

  database.push(newUser);

  clearForm();

  return;
}

function clearForm() {
  document.getElementById("ad").value = "";
  document.getElementById("soyad").value = "";
  document.getElementById("yas").value = "";
  document.getElementById("sifre").value = "";
  document.getElementById("email").value = "";
  Array.from(document.querySelectorAll('input[name="hobi"]:checked')).forEach(
    (hobi) => (hobi.checked = false)
  );
}

function printObjects() {
  console.log(database);
}

function printNames() {
  for (let i = 0; i < database.length; i++) {
    const name = database[i].Ad;
    console.log(name);
  }
}

function printFullNames() {
  for (let i = 0; i < database.length; i++) {
    const fullName = database[i].Ad + " " + database[i].Soyad;
    console.log(fullName);
  }
}




