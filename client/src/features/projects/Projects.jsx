import { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchProjects } from './projectsSlice';

export default function Skills() {
  const dispatch = useDispatch();
  const { data: projects, status, error } = useSelector((state) => state.projects);

  useEffect(() => {
    if (status === 'idle') {
      dispatch(fetchProjects());
    }
  }, [dispatch, status]);

  if (status === 'loading') return <p className="text-gray-500 text-center mt-4">Loading...</p>;
  if (status === 'failed') return <p className="text-red-500 text-center mt-4">Error: {error}</p>;

  return (
    <div className="max-w-4xl mx-auto px-4 py-6">
      <h2 className="text-3xl font-bold mb-6 text-center text-blue-600">My Projects</h2>
      <ul className="space-y-4">
        {projects.map((project) => (
          <li
            key={project.id}
            className="border border-gray-300 rounded-lg p-4 shadow hover:shadow-md transition duration-200"
          >
            <h3 className="text-xl font-semibold text-gray-800">{project.name}</h3>
            <p className="text-gray-600 mt-1">{project.description}</p>
            <p className="text-sm mt-2 text-gray-500">
              <span className="font-medium">Duration:</span>{' '}
              {project.startDate ? project.startDate.substring(0, 4) : ''} -{' '}
              {project.endDate ? project.endDate.substring(0, 4) : ''}
            </p>
            <p className="text-sm mt-1 text-gray-500">
              <span className="font-medium">Technologies:</span>{' '}
              {project.technologies && project.technologies.length > 0
                ? project.technologies.join(', ')
                : 'No technologies'}
            </p>
            <a
              href={project.url}
              target="_blank"
              rel="noopener noreferrer"
              className="text-blue-500 hover:underline mt-2 inline-block"
            >
              View Project
            </a>
          </li>
        ))}
      </ul>
    </div>
  );
}
