

// نمایش سال جاری در فوتر
const yearSpan = document.getElementById('y');
if (yearSpan) {
    yearSpan.textContent = new Date().getFullYear();
}


// هندل فرم تماس (ثبت و ریست)
const form = document.getElementById('contactForm');
if (form) {
    form.addEventListener('submit', function (e) {
        e.preventDefault();
        alert('درخواست شما با موفقیت ثبت شد. به‌زودی با شما تماس خواهیم گرفت.');
        form.reset();
    });
}

// توجه:
// Dropdown جدید با CSS ساخته شده و نیازی به JS ندارد
