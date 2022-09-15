import { FC } from "react";
import { Row, Col } from "antd";
import ClientsDetail from "../components/ClientsDetail/ClientsDetail";

const ClientDetail: FC = () => {
  return (
    <Row gutter={24}>
      <Col span={4} />
      <Col span={16}>
        <ClientsDetail />
      </Col>
      <Col span={4} />
    </Row>
  );
};

export default ClientDetail;
