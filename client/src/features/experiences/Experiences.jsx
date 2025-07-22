import { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchExperiences } from './experiencesSlice';

export default function Experiences() {
  const dispatch = useDispatch();
const { data: experiences = [], status = 'idle', error = null } = useSelector((state) => state.experiences) || {};
  useEffect(() => {
    if (status === 'idle') {
      dispatch(fetchExperiences()); 
    }
  }, [dispatch, status]);

  if (status === 'loading') return <p>loading..</p>;
  if (status === 'failed') return <p>error: {error}</p>;

  return (
    <div>
      <h2>my Experiences</h2>
      <ul>
        {experiences.map((experience) => (
           <li key={experience.id}>
            {experience.companyName} | {experience.role} | 
            {experience.startDate ? experience.startDate.substring(0, 4) : ''}  -  
            {experience.endDate ? experience.endDate.substring(0, 4) : ''} | 
            {experience.description}
          </li>
        ))}
      </ul>
    </div>
  );
}
