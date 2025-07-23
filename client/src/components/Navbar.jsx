// import { useSelector } from 'react-redux';

// export default function Navbar() {
//       const profile = useSelector((state) => state.profile.data);

//   return (
//     <header className="bg-[#0e1a20] text-white fixed top-0 w-full z-50 shadow">
//       <nav className="max-w-7xl mx-auto px-4 py-4 flex justify-between items-center">
//         <h1 className="text-2xl font-bold text-[#fce8c7]">{profile.fullName}</h1>
//         <ul className="flex space-x-6 text-[#fce8c7] font-medium">
//           <li><a href="#home" className="hover:underline">Home</a></li>
//           <li><a href="#about" className="hover:underline">About</a></li>
//           <li><a href="#projects" className="hover:underline">Projects</a></li>
//           <li><a href="#contact" className="hover:underline">Contact</a></li>
//         </ul>
//       </nav>
//     </header>
//   );
// }


import { useState, useEffect } from "react";
import { useSelector } from "react-redux";

export default function Navbar() {
  const profile = useSelector((state) => state.profile.data);
  const [activeSection, setActiveSection] = useState("home");

  useEffect(() => {
    const sections = ["home", "about", "projects", "contact"];

    function onScroll() {
      const scrollPosition = window.scrollY + 120; // פיצוי לגובה navbar + מרווח קטן

      for (let i = 0; i < sections.length; i++) {
        const section = document.getElementById(sections[i]);
        if (section) {
          const sectionTop = section.offsetTop;
          const sectionHeight = section.offsetHeight;

          if (
            scrollPosition >= sectionTop &&
            scrollPosition < sectionTop + sectionHeight
          ) {
            setActiveSection(sections[i]);
            break;
          }
        }
      }
    }

    window.addEventListener("scroll", onScroll);
    // בודקים את המקטע הפעיל גם ברינדור הראשוני
    onScroll();

    return () => window.removeEventListener("scroll", onScroll);
  }, []);

  return (
    <header className="bg-[#0e1a20] text-white fixed top-0 w-full z-50 shadow">
      <nav className="max-w-7xl mx-auto px-4 py-4 flex justify-between items-center">
        <h1 className="text-2xl font-bold text-[#fce8c7]">{profile.fullName}</h1>
        <ul className="flex space-x-6 text-[#fce8c7] font-medium">
          {["home", "about", "projects", "contact"].map((section) => (
            <li key={section}>
              <a
                href={`#${section}`}
                className={`hover:underline ${
                  activeSection === section ? "border-b-2 border-[#fce8c7]" : ""
                }`}
              >
                {section.charAt(0).toUpperCase() + section.slice(1)}
              </a>
            </li>
          ))}
        </ul>
      </nav>
    </header>
  );
}
