import React from 'react';
import Skills from '../features/skills/Skills';
import Profile from '../features/profile/Profile';
import Experiences from '../features/experiences/Experiences';
import Projects from '../features/projects/Projects';

function Body() {
return(
  <>    
    <Skills /> 
    <Profile />
    <Experiences />
    <Projects />
  </>);
}

export default Body;