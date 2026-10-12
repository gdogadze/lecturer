(function () {
  function show(node, text) {
    node.hidden = false;
    node.textContent = text;
  }

  document.querySelectorAll(".quiz").forEach(function (quiz) {
    var feedback = quiz.querySelector(".feedback");
    quiz.querySelectorAll("button[data-choice]").forEach(function (button) {
      button.addEventListener("click", function () {
        quiz.querySelectorAll("button[data-choice]").forEach(function (other) {
          other.classList.remove("is-right", "is-wrong");
        });
        var ok = button.dataset.choice === quiz.dataset.answer;
        button.classList.add(ok ? "is-right" : "is-wrong");
        show(feedback, button.dataset.why || "");
      });
    });
  });

  document.querySelectorAll(".bin-item").forEach(function (item) {
    var feedback = item.querySelector(".bin-feedback");
    item.querySelectorAll("button[data-pick]").forEach(function (button) {
      button.addEventListener("click", function () {
        item.querySelectorAll("button[data-pick]").forEach(function (other) {
          other.classList.remove("is-right", "is-wrong");
        });
        var ok = button.dataset.pick === item.dataset.expect;
        button.classList.add(ok ? "is-right" : "is-wrong");
        show(feedback, ok ? item.dataset.yes : item.dataset.no);
      });
    });
  });

  document.querySelectorAll(".runner").forEach(function (runner) {
    var expected = (runner.dataset.steps || "").split(",");
    var cursor = 0;
    var failed = false;
    var log = runner.querySelector(".runner-log");
    var result = runner.querySelector(".runner-result");
    var buttons = runner.querySelectorAll("button[data-step]");

    function reset() {
      cursor = 0;
      failed = false;
      log.replaceChildren();
      result.textContent = "";
      buttons.forEach(function (button) {
        button.disabled = false;
        button.classList.remove("is-right", "is-wrong");
      });
    }

    buttons.forEach(function (button) {
      button.addEventListener("click", function () {
        if (failed || cursor === expected.length) return;
        var step = button.dataset.step;
        var line = document.createElement("li");
        if (step === expected[cursor]) {
          button.classList.add("is-right");
          button.disabled = true;
          line.textContent = button.dataset.ok;
          log.appendChild(line);
          cursor += 1;
          if (cursor === expected.length) result.textContent = runner.dataset.done;
          return;
        }
        failed = true;
        button.classList.add("is-wrong");
        line.textContent = button.dataset.bad;
        log.appendChild(line);
        result.textContent = runner.dataset.retry;
        buttons.forEach(function (other) { other.disabled = true; });
      });
    });

    var resetButton = runner.querySelector(".reset");
    if (resetButton) resetButton.addEventListener("click", reset);
  });

  document.querySelectorAll(".checker").forEach(function (form) {
    form.addEventListener("submit", function (event) {
      event.preventDefault();
      var text = form.querySelector("textarea").value;
      var list = form.querySelector(".checker-list");
      list.replaceChildren();
      var missing = [];
      (form.dataset.need || "").split(",").forEach(function (pair) {
        var parts = pair.split("|");
        var token = parts[0];
        var label = parts[1] || token;
        var item = document.createElement("li");
        if (text.indexOf(token) !== -1) {
          item.textContent = label + " — არის.";
          item.className = "is-right";
        } else {
          item.textContent = label + " — აკლია.";
          item.className = "is-wrong";
          missing.push(label);
        }
        list.appendChild(item);
      });
      var result = form.querySelector(".checker-result");
      result.textContent = missing.length
        ? "ჯერ ეს დაამატეთ, მერე ისევ შეამოწმეთ."
        : form.dataset.done || "ფორმა სწორია.";
    });
  });

  document.querySelectorAll(".ticks").forEach(function (list) {
    var key = "comp-m205-" + (list.dataset.store || "lab");
    var saved = {};
    try { saved = JSON.parse(localStorage.getItem(key) || "{}"); } catch (error) { saved = {}; }
    list.querySelectorAll("input[type=checkbox]").forEach(function (box, index) {
      box.checked = Boolean(saved[index]);
      box.addEventListener("change", function () {
        var next = {};
        list.querySelectorAll("input[type=checkbox]").forEach(function (item, itemIndex) {
          next[itemIndex] = item.checked;
        });
        localStorage.setItem(key, JSON.stringify(next));
      });
    });
  });
})();
