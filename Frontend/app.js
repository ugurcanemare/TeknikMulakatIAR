let cartCount = 0;
  let allCards = document.querySelectorAll(".card");
  let visibleCards = [...allCards];

  function addToCart(button) {
    button.parentElement.style.display = "none";
    cartCount++;
    updateCartCount();

    // Yalnızca görünen kartları güncelle
    visibleCards = visibleCards.filter(card => card.style.display !== "none");
  }

  function updateCartCount() {
    const cartIcon = document.querySelector(".cart-icon");
    const countElement = cartIcon.querySelector(".count");
    countElement.textContent = cartCount;
  }

  const searchInput = document.getElementById("searchInput");
  searchInput.addEventListener("input", function() {
    const filter = searchInput.value.toLowerCase();

    // Kartları filtrele ve görünürlüklerini ayarla
    visibleCards.forEach(function(card) {
      const cardText = card.textContent.toLowerCase();

      if (cardText.includes(filter)) {
        card.style.display = "block";
      } else {
        card.style.display = "none";
      }
    });
  });